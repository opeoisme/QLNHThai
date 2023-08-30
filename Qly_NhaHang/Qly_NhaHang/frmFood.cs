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
            gridView.CustomDrawCell += gridView1_CustomDrawCell;
        }

        private void InitializeDbContext()
        {
            dbContext = new QLNHThaiEntities();
        }

        public void LoadFoodData()
        {
            var foodData = dbContext.Foods
                .Select(f => new FoodModel
                {
                    id_Food = f.id_Food,
                    name_Food = f.name_Food,
                    price_Food = (float)f.price_Food,
                    condition_Food = f.condition_Food,
                    image_Food = f.image_Food,
                    id_Category = f.id_Category
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
                cbbCondition.SelectedItem = selectedFood.condition_Food;
                nmrPriceFood.Value = (decimal)selectedFood.price_Food;

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

        private void LoadCategoryData()
        {
            var categories = dbContext.CategoryFoods.ToList();
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
                    MessageBox.Show("Lỗi khi chuyển đổi hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            food.condition_Food = cbbCondition.SelectedItem?.ToString();
            food.price_Food = (float)nmrPriceFood.Value;
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
                Food foodToUpdate = dbContext.Foods.FirstOrDefault(f => f.id_Food == foodId);

                if (foodToUpdate != null)
                {
                    UpdateFoodProperties(foodToUpdate);

                    dbContext.Entry(foodToUpdate).State = EntityState.Modified;

                    if (isImageChanged && imageFood.Image != null)
                    {
                        UpdateFoodImage(foodToUpdate);
                    }

                    dbContext.SaveChanges();
                    LoadFoodData();
                }
            }
            // Reset isImageChanged sau khi đã sử dụng
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
                        Food foodToDelete = dbContext.Foods.FirstOrDefault(f => f.id_Food == foodId);

                        if (foodToDelete != null)
                        {
                            foodToDelete.condition_Food = "Ngừng bán";
                            dbContext.SaveChanges();

                            // Load lại danh sách sau khi cập nhật
                            LoadFoodData();

                            // Mờ trường dữ liệu tương ứng trên GridView
                            gridView1.SetRowCellValue(focusedRowHandle, gridView1.Columns["condition_Food"], "Ngừng bán");
                            MessageBox.Show("Sản phẩm không còn được phục vụ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            GridView view = sender as GridView;

            if (e.RowHandle >= 0)
            {
                FoodModel food = view.GetRow(e.RowHandle) as FoodModel;
                if (food != null && food.condition_Food == "Ngừng bán")
                {
                    e.Appearance.ForeColor = Color.Gray; // Áp dụng màu chữ xám
                }
            }
        }

        private void btnReloadFood_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gridView1.GetSelectedRows();
            int updatedCount = 0; // Số lượng sản phẩm đã được cập nhật

            foreach (int rowHandle in selectedRows)
            {
                FoodModel selectedFood = gridView1.GetRow(rowHandle) as FoodModel;
                if (selectedFood != null && selectedFood.condition_Food != "Được sử dụng")
                {
                    if (int.TryParse(selectedFood.id_Food.ToString(), out int foodId))
                    {
                        Food foodToUpdate = dbContext.Foods.FirstOrDefault(f => f.id_Food == foodId);

                        if (foodToUpdate != null)
                        {
                            foodToUpdate.condition_Food = "Được sử dụng";
                            dbContext.SaveChanges();
                            updatedCount++; // Tăng số lượng sản phẩm đã cập nhật
                        }
                    }
                }
            }
            LoadFoodData();
            if (updatedCount > 0)
            {
                MessageBox.Show($" {updatedCount} sản phẩm đã được đưa vào sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sản phẩm đang được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        //private Stream GetImageStream(int rowHandle)
        //{
        //    if (gridView1.GetRowCellValue(rowHandle, "image_Food") is byte[] imageBytes)
        //    {
        //        // Tạo một bản sao của mảng bytes hình ảnh
        //        byte[] imageCopy = new byte[imageBytes.Length];
        //        Array.Copy(imageBytes, imageCopy, imageBytes.Length);

        //        return new MemoryStream(imageCopy);
        //    }
        //    return null;
        //}

        #endregion

    }
}
