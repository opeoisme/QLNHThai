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
        
        public uctFood(string nameFood, double priceFood)
        {
            InitializeComponent();
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
    }
}
