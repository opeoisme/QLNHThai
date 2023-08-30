using DevExpress.XtraEditors;
using Qly_NhaHang.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmOrder : DevExpress.XtraEditors.XtraForm
    {
        public frmOrder()
        {
            InitializeComponent();
            LoadFoodFLPN();
            LoadCategoryFLPN();
        }

        private void LoadCategoryFLPN()
        {
            using (var context = new QLNHThaiEntities()) // Thay "YourDbContext" bằng context của bạn
            {
                var CategoryList = context.CategoryFoods.ToList();

                foreach (var category in CategoryList)
                {
                    Button button = new Button();
                    button.Text = category.name_Category;
                    button.Tag = category.id_Category; // Lưu Id của Category vào Tag để dễ dàng truy xuất sau này
                    button.BackColor = Color.Teal; // Đặt màu nền teal cho button
                    button.ForeColor = Color.White; // Đặt màu chữ trắng cho button
                    button.Width = 200; // Đặt kích thước ngang
                    button.Height = 72;
                    button.Click += CategoryButton_Click; // Gắn sự kiện Click cho mỗi button
                    flpnCategory.Controls.Add(button);
                }
            }
        }
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int categoryId = (int)clickedButton.Tag;
            DisplayFoodsByCategory(categoryId);
            // Thực hiện hành động tương ứng với categoryId, ví dụ:
            // Hiển thị danh sách sản phẩm thuộc Category này
        }

        private void DisplayFoodsByCategory(int categoryId)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var foodsInCategory = dbContext.Foods.Where(food => food.id_Category == categoryId && food.condition_Food == "Được sử dụng").ToList();

                flpnFoodMenu.Controls.Clear(); // Xóa hết các user control cũ

                foreach (var food in foodsInCategory)
                {
                    // Tạo và thêm User Control hiển thị thông tin món ăn (Food) vào flpnFood
                    uctFood foodControl = new uctFood(food.name_Food, food.price_Food);
                    flpnFoodMenu.Controls.Add(foodControl);
                }
            }
        }
        private void LoadFoodFLPN()
        {
            using (var context = new QLNHThaiEntities())
            {
                var FoodList = context.Foods.Where(food => food.condition_Food == "Được sử dụng").ToList();

                foreach (var monAn in FoodList)
                {
                    // Tạo instance của user control và thêm vào FlowLayoutPanel
                    var Foodct = new uctFood(monAn.name_Food, monAn.price_Food);
                    flpnFoodMenu.Controls.Add(Foodct);
                }
            }
        }

    }
}