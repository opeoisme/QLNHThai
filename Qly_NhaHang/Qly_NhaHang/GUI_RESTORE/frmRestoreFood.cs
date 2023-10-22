using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Qly_NhaHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmRestoreFood : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmRestoreFood()
        {
            InitializeComponent();
            InitializeDbContext();
            InitializeGridViewOptions();
            LoadCategoryData();
        }

        private void InitializeDbContext()
        {
            dbContext = new QLNHThaiEntities();
        }

        private void InitializeGridViewOptions()
        {
            GridView gridView = gctFood.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gridView1_FocusedRowChanged;
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
                .Where(joinResult => joinResult.Food.condition_Food == "Ngừng bán" && joinResult.Category.condition_Category == "Được sử dụng")
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
        private void btnLoadFood_Click(object sender, EventArgs e)
        {
            LoadFoodData();
        }

        private void btnReloadFood_Click(object sender, EventArgs e)
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
                            foodToUpdate.condition_Food = "Được sử dụng";

                            // Đánh dấu đối tượng là thay đổi
                            dbContext.Entry(foodToUpdate).State = EntityState.Modified;

                            // Lưu thay đổi
                            dbContext.SaveChanges();

                            // Nạp lại dữ liệu sau khi cập nhật
                            LoadFoodData();
                            XtraMessageBox.Show("Sản phẩm đưa vào kinh doanh !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void frmRestoreFood_Load(object sender, EventArgs e)
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

        private void LoadCategoryData()
        {
            var categories = dbContext.CategoryFoods.ToList();
            cbbCategory.DataSource = categories;
            cbbCategory.DisplayMember = "name_Category";
            cbbCategory.ValueMember = "id_Category";
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
                int rowHeight = 60; // Điều chỉnh chiều cao của mỗi hàng
                double y = 20; // Vị trí bắt đầu của hàng đầu tiên

                // Đặt kích thước trang PDF
                PdfPage page = pdf.AddPage();
                page.Width = XUnit.FromInch(8.5); // Kích thước trang Letter (8.5 x 11 inch)
                page.Height = XUnit.FromInch(11);

                XGraphics gfx = XGraphics.FromPdfPage(page);

                for (int row = 0; row < gridView1.RowCount; row++)
                {
                    double x = 20;

                    if (row == 0)
                    {
                        // Vẽ tiêu đề cột cho trang đầu tiên
                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
                        {
                            gfx.DrawString(column.Caption, font, XBrushes.Black, x, y);
                            x += 100;
                        }
                        y += 20; // Điều chỉnh khoảng cách giữa tiêu đề cột và dữ liệu
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

                                    // Điều chỉnh kích thước của hình ảnh để tối ưu hóa trên trang
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

                    // Kiểm tra nếu không đủ không gian cho hàng tiếp theo, tạo trang mới
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
                    // Đặt chiều rộng cột cho tất cả các cột là 15
                    for (int col = 0; col < gridView1.Columns.Count; col++)
                    {
                        worksheet.Column(col + 1).Width = 15;
                    }
                    // Tiêu đề cột
                    for (int i = 0; i < gridView1.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = gridView1.Columns[i].Caption;
                    }
                    for (int row = 0; row < gridView1.RowCount; row++)
                    {
                        // Đặt chiều cao hàng là 60
                        worksheet.Row(row + 2).Height = 60;

                        for (int col = 0; col < gridView1.Columns.Count; col++)
                        {
                            if (gridView1.Columns[col].FieldName == "image_Food") // Xử lý cột hình ảnh
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
    }
}