using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting.Export.Pdf;
using Qly_NhaHang.Models;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Image = System.Drawing.Image;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfDocument = PdfSharp.Pdf.PdfDocument;
using PdfPage = PdfSharp.Pdf.PdfPage;
using System.Drawing.Imaging;
using System.Collections.Generic;
using DevExpress.XtraEditors;

namespace Qly_NhaHang
{
    public partial class frmFood : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        private bool isImageChanged = false;
        public frmFood()
        {
            InitializeComponent();
            InitializeGridViewOptions();
            InitializeDbContext();
            LoadCategoryData();
            LoadFoodData();
        }

        // Hàm xử lý
        #region method
        private void InitializeGridViewOptions()
        {
            GridView gridView = gctFood.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gridView1_FocusedRowChanged;
        }

        private void InitializeDbContext()
        {
            dbContext = new QLNHThaiEntities();
        }

        public void LoadFoodData()
        {
            var foodData = dbContext.Foods
                .Join(
                    dbContext.CategoryFoods,
                    food => food.id_Category,
                    category => category.id_Category,
                    (food, category) => new { Food = food, Category = category }
                )
                .Where(joinResult => joinResult.Food.condition_Food == "Được sử dụng" && joinResult.Category.condition_Category == "Được sử dụng")
                .Select(joinResult => new FoodModel
                {
                    id_Food = joinResult.Food.id_Food,
                    name_Food = joinResult.Food.name_Food,
                    price_Food = (float)joinResult.Food.price_Food,
                    condition_Food = joinResult.Food.condition_Food,
                    image_Food = joinResult.Food.image_Food,
                    id_Category = joinResult.Food.id_Category
                })
                .ToList();

            gctFood.DataSource = foodData;
        }


        private void UpdateFoodControls(int focusedRowHandle)
        {
            FoodModel selectedFood = gridView1.GetRow(focusedRowHandle) as FoodModel;
            if (selectedFood != null)
            {
                txbIdFood.Text = selectedFood.id_Food.ToString();
                txbNameFood.Text = selectedFood.name_Food;
                cbbCategory.SelectedValue = selectedFood.id_Category;
                txbPriceFood.Text = String.Format("{0:0,0}", selectedFood.price_Food);

                if (selectedFood.image_Food != null)
                {
                    using (MemoryStream ms = new MemoryStream(selectedFood.image_Food))
                    {
                        imageFood.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    imageFood.Image = Properties.Resources.Food0;
                }
            }
        }

        private bool ValidateAndSetFoodProperties(Food food)
        {
            food.name_Food = txbNameFood.Text;
            food.id_Category = Convert.ToInt32(cbbCategory.SelectedValue);
            if (double.TryParse(txbPriceFood.Text, out double price))
            {
                food.price_Food = price;
            }
            else
            {
                XtraMessageBox.Show("Giá bán không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; 
            }
            return true;
        }


        private void LoadCategoryData()
        {
            var categories = dbContext.CategoryFoods
                 .Where(category => category.condition_Category == "Được sử dụng")
                .ToList();
            cbbCategory.DataSource = categories;
            cbbCategory.DisplayMember = "name_Category";
            cbbCategory.ValueMember = "id_Category";

            
        }


        private void SelectAndSaveImage()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;";
            DialogResult choose = open.ShowDialog();
            if (choose == DialogResult.OK)
            {
                string imagePath = open.FileName;

                using (Bitmap imageBitmap = new Bitmap(Image.FromFile(imagePath)))
                {
                    imageFood.Image = new Bitmap(imageBitmap);

                    byte[] imageBytes = ConvertImageToByteArray(imageBitmap);
                    if (imageBytes != null)
                    {
                        UpdateFoodImageInDatabase(imageBytes);
                    }
                }
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    image.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi khi chuyển đổi hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void UpdateFoodImageInDatabase(byte[] imageBytes)
        {
            if (int.TryParse(txbIdFood.Text, out int selectedFoodId))
            {
                Food foodToUpdate = dbContext.Foods.FirstOrDefault(food => food.id_Food == selectedFoodId);

                if (foodToUpdate != null)
                {
                    foodToUpdate.image_Food = imageBytes;
                    dbContext.Entry(foodToUpdate).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
            }
        }


        private void UpdateFoodProperties(Food food)
        {
            food.name_Food = txbNameFood.Text;
            food.id_Category = Convert.ToInt32(cbbCategory.SelectedValue);
            if (double.TryParse(txbPriceFood.Text, out double price))
            {
                food.price_Food = price;
            }
            else
            {
                XtraMessageBox.Show("Giá trị không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateFoodImage(Food foodToUpdate)
        {
            byte[] imageBytes = ConvertImageToByteArray(imageFood.Image);
            if (imageBytes != null)
            {
                foodToUpdate.image_Food = imageBytes;
                dbContext.SaveChanges();
            }
        }

        #endregion


        // sự kiện

        #region events
        private void frmFood_Load(object sender, EventArgs e)
        {
            LoadFoodData();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateFoodControls(e.FocusedRowHandle);
            }
        }

        private void imageFood_Click(object sender, EventArgs e)
        {
            SelectAndSaveImage();
            isImageChanged = true;
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbIdFood.Text, out int foodId))
            {
                Food foodToUpdate = dbContext.Foods.FirstOrDefault(i => i.id_Food == foodId);

                if (foodToUpdate != null)
                {
                    if (ValidateAndSetFoodProperties(foodToUpdate))
                    {
                        dbContext.Entry(foodToUpdate).State = EntityState.Modified;

                        if (isImageChanged && imageFood.Image != null)
                        {
                            UpdateFoodImage(foodToUpdate);
                        }
                        dbContext.SaveChanges();
                        LoadFoodData();
                        XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            isImageChanged = false;
        }

        private void btnLoadFood_Click(object sender, EventArgs e)
        {
            LoadFoodData();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmAddFood addFoodForm = new frmAddFood();
            DialogResult result = addFoodForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadFoodData();
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gridView1.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                FoodModel selectedFood = gridView1.GetRow(focusedRowHandle) as FoodModel;
                if (selectedFood != null)
                {
                    if (int.TryParse(selectedFood.id_Food.ToString(), out int foodId))
                    {
                        Food foodToUpdate = dbContext.Foods.FirstOrDefault(f => f.id_Food == foodId);
                        if (foodToUpdate != null)
                        {
                            foodToUpdate.condition_Food = "Ngừng bán";
                            dbContext.Entry(foodToUpdate).State = EntityState.Modified;
                            dbContext.SaveChanges();
                            LoadFoodData();
                            XtraMessageBox.Show("Sản phẩm ngừng kinh doanh !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnCSVFood_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("FoodData");
                    for (int col = 0; col < gridView1.Columns.Count; col++)
                    {
                        worksheet.Column(col + 1).Width = 15;
                    }
                    for (int i = 0; i < gridView1.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = gridView1.Columns[i].Caption;
                    }
                    for (int row = 0; row < gridView1.RowCount; row++)
                    {
                        worksheet.Row(row + 2).Height = 60;

                        for (int col = 0; col < gridView1.Columns.Count; col++)
                        {
                            if (gridView1.Columns[col].FieldName == "image_Food") 
                            {
                                byte[] imageBytes = gridView1.GetRowCellValue(row, gridView1.Columns[col]) as byte[];
                                if (imageBytes != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        var image = worksheet.AddPicture(ms).MoveTo(worksheet.Cell(row + 2, col + 1));
                                        image.Width = 80;
                                        image.Height = 80;
                                    }
                                }
                            }
                            else
                            {
                                object cellValue = gridView1.GetRowCellValue(row, gridView1.Columns[col]);
                                worksheet.Cell(row + 2, col + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                            }
                        }
                    }
                    workbook.SaveAs(filePath);
                }
                XtraMessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPDFFood_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Danh sách món ăn";
                XFont font = new XFont("Arial", 7);
                int rowHeight = 60;
                double y = 20;
                PdfPage page = pdf.AddPage();
                page.Width = XUnit.FromInch(8.5);
                page.Height = XUnit.FromInch(11);
                XGraphics gfx = XGraphics.FromPdfPage(page);
                for (int row = 0; row < gridView1.RowCount; row++)
                {
                    double x = 20;

                    if (row == 0)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
                        {
                            gfx.DrawString(column.Caption, font, XBrushes.Black, x, y);
                            x += 100;
                        }
                        y += 20;
                        x = 20;
                    }
                    for (int col = 0; col < gridView1.Columns.Count; col++)
                    {
                        object cellValue = gridView1.GetRowCellValue(row, gridView1.Columns[col]);
                        if (gridView1.Columns[col].FieldName == "image_Food")
                        {
                            byte[] imageBytes = cellValue as byte[];
                            if (imageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);
                                    double imageWidth = 50;
                                    double imageHeight = 30;
                                    XImage xImage = XImage.FromStream(ms);
                                    gfx.DrawImage(xImage, x, y, imageWidth, imageHeight);
                                }
                            }
                            else
                            {
                                gfx.DrawString("", font, XBrushes.Black, x, y);
                            }
                        }
                        else
                        {
                            gfx.DrawString(cellValue != null ? cellValue.ToString() : string.Empty, font, XBrushes.Black, x, y);
                        }
                        x += 100;
                    }
                    y += rowHeight;
                    if (y + rowHeight > page.Height - 20 && row < gridView1.RowCount - 1)
                    {
                        page = pdf.AddPage();
                        page.Width = XUnit.FromInch(8.5);
                        page.Height = XUnit.FromInch(11);
                        gfx = XGraphics.FromPdfPage(page);
                        y = 20;
                    }
                }
                pdf.Save(filePath);
                XtraMessageBox.Show("Dữ liệu đã được xuất ra tệp PDF thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion


    }
}
