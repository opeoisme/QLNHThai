﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Bibliography;
using Qly_NhaHang.DAO;
using Qly_NhaHang.Models;
using Qly_NhaHang.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmOrder : DevExpress.XtraEditors.XtraForm
    {
        private int _idBan;
        private int _idBill;
        BAN _ban;
        Bill_DAO _bill;
        private QLNHThaiEntities dbContext;
        public frmOrder()
        {
            InitializeComponent();
            InitializeGridViewOptions();

        }
        public void frmOrder_Load(object sender, EventArgs e)
        {
            _ban = new BAN();
            lblID.Text = _idBan.ToString(); // Cập nhật lblID.Text bằng giá trị _idBan
            _bill = new Bill_DAO();
            lblIDBILL.Text = _idBill.ToString();
            LoadFoodFLPN();
            LoadCategoryFLPN();
            LoadBillInfo();  // Load dữ liệu BillInfo
        }

        #region method
        public void SetIdBill(int idBill)
        {
            _idBill = idBill;
        }

        public void SetIdBan(int idBan)
        {
            _idBan = idBan;
        }

        private void InitializeGridViewOptions()
        {
            GridView gridView = gctBill.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
        }

        public void LoadCategoryFLPN()
        {
            using (var context = new QLNHThaiEntities()) // Thay "YourDbContext" bằng context của bạn
            {
                var CategoryList = context.CategoryFoods.Where(category => category.condition_Category == "Được sử dụng").ToList();

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


        private void DisplayFoodsByCategory(int categoryId)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var foodsInCategory = dbContext.Foods.Where(food => food.id_Category == categoryId && food.condition_Food == "Được sử dụng").ToList();

                flpnFoodMenu.Controls.Clear(); // Xóa hết các user control cũ

                foreach (var food in foodsInCategory)
                {
                    // Tạo và thêm User Control hiển thị thông tin món ăn (Food) vào flpnFood
                    uctFood foodControl = new uctFood(food.name_Food, food.price_Food, _idBill, GetFoodCount(food.id_Food));

                    flpnFoodMenu.Controls.Add(foodControl);
                }
            }
        }

        public void LoadFoodFLPN()
        {
            using (var context = new QLNHThaiEntities())
            {
                var FoodList = (from food in context.Foods
                                join category in context.CategoryFoods
                                on food.id_Category equals category.id_Category
                                where food.condition_Food == "Được sử dụng" && category.condition_Category == "Được sử dụng"
                                select food).ToList();

                foreach (var monAn in FoodList)
                {
                    // Tạo instance của user control và thêm vào FlowLayoutPanel
                    var Foodct = new uctFood(monAn.name_Food, monAn.price_Food, _idBill, GetFoodCount(monAn.id_Food));
                    flpnFoodMenu.Controls.Add(Foodct);
                }
            }
        }



        public void LoadBillInfo()
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var billInfoData = dbContext.Bill_Info.Where(bi => bi.id_Bill == _idBill)
                    .Select(f => new BillInfoViewModel
                    {
                        id_Bill = f.id_Bill,
                        id_BillInfo = f.id_BillInfo,
                        count_Food = f.count_Food,
                        id_Food = f.id_Food,
                    })
                    .ToList();
                gctBill.DataSource = billInfoData;

                double total = CalculateTotalPrice();


              lblTotalPrice.Text = String.Format("{0:0,0 vnđ}", total);
            }
        }

        public int GetFoodCount(int foodId)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var billInfoData = dbContext.Bill_Info
                    .Where(bi => bi.id_Bill == _idBill && bi.id_Food == foodId)
                    .Select(f => f.count_Food)
                    .FirstOrDefault();
                return billInfoData;
            }
        }

        public void LoadFoodFLPNTest()
        {
            flpnFoodMenu.Controls.Clear(); // Xóa hết các user control cũ trước khi tải dữ liệu mới
            using (var context = new QLNHThaiEntities())
            {
                var FoodList = (from food in context.Foods
                                join category in context.CategoryFoods
                                on food.id_Category equals category.id_Category
                                where food.condition_Food == "Được sử dụng" && category.condition_Category == "Được sử dụng"
                                select food).ToList();


                foreach (var monAn in FoodList)
                {
                    // Tạo instance của user control và thêm vào FlowLayoutPanel
                    var Foodct = new uctFood(monAn.name_Food, monAn.price_Food, _idBill, GetFoodCount(monAn.id_Food));
                    flpnFoodMenu.Controls.Add(Foodct);
                }
            }
        }

        public double CalculateTotalPrice()
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var billInfoData = dbContext.Bill_Info
                    .Where(bi => bi.id_Bill == _idBill)
                    .Join(dbContext.Foods, bi => bi.id_Food, food => food.id_Food, (bi, food) => new { bi.count_Food, food.price_Food })
                    .ToList();

                double total = billInfoData.Sum(item => item.count_Food * item.price_Food);
                return total;
            }
        }


        #endregion

        #region events
        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int categoryId = (int)clickedButton.Tag;
            DisplayFoodsByCategory(categoryId);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void UpdateTotalPriceInBill(double total)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var billToUpdate = dbContext.Bills.FirstOrDefault(b => b.id_Bill == _idBill);

                if (billToUpdate != null)
                {
                    billToUpdate.totalPrice_Bill = total;
                    dbContext.SaveChanges();
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double total = CalculateTotalPrice();
            UpdateTotalPriceInBill(total);
            frmThanhToan thanhToanForm = new frmThanhToan(_idBill, total);
            this.Hide();
            thanhToanForm.ShowDialog();
            this.Show();
        }
    }
}