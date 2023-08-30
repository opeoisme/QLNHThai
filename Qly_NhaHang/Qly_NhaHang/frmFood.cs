using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using Qly_NhaHang.Models;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

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

        #endregion

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmAddFood addFoodForm = new frmAddFood();
            DialogResult result = addFoodForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Nếu kết quả là OK (người dùng đã thêm dữ liệu), bạn có thể thực hiện các thao tác cần thiết ở đây.
                // Ví dụ: cập nhật danh sách món ăn, tải lại dữ liệu, ...
                LoadFoodData();
            }
            }

        private void btnLoadFood_Click(object sender, EventArgs e)
        {
            LoadFoodData();
        }
    }
}
