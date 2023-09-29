using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
                cbbCondition.Text = selectedFood.condition_Food;
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
    }
}