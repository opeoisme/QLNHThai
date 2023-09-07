using DevExpress.XtraEditors;
using Qly_NhaHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Skins.SolidColorHelper;

namespace Qly_NhaHang.UserControl
{
    public partial class uctFood : DevExpress.XtraEditors.XtraUserControl 
    {
        private int idBill;
        private string nameFood;
        private double priceFood;
        private int foodCount;

        public uctFood(string nameFood, double priceFood, int _idBill, int foodCount)
        {
            InitializeComponent();
            this.nameFood = nameFood;
            this.priceFood = priceFood;
            this.idBill = _idBill;
            this.foodCount = foodCount;
            lblFoodName.Text = nameFood ;
            lblPrice.Text = priceFood.ToString("c");

            using (var dbContext = new QLNHThaiEntities()) // Thay thế YourDbContext bằng tên DbContext của bạn
            {
                var food = dbContext.Foods.FirstOrDefault(f => f.name_Food == nameFood);
                if (food != null && food.image_Food != null)
                {
                    using (MemoryStream ms = new MemoryStream(food.image_Food))
                    {
                        imageFood.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Load ảnh mặc định từ tài nguyên
                    imageFood.Image = Properties.Resources.Food0;
                }
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmPickFood pickFoodForm = new frmPickFood(nameFood, priceFood, idBill, foodCount);
            pickFoodForm.ShowDialog();
        }

        
    }
}
