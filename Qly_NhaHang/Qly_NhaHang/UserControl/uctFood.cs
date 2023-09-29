using DevExpress.XtraEditors;
using DocumentFormat.OpenXml.Vml;
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
            lblPrice.Text = lblPrice.Text = String.Format("{0:0,0 vnđ}", priceFood);

            using (var dbContext = new QLNHThaiEntities()) 
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
                    imageFood.Image = Properties.Resources.Food0;
                }
            }
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            frmPickFood pickFoodForm = new frmPickFood(nameFood, priceFood, idBill, foodCount);
            pickFoodForm.ShowDialog();
        }

        private void imageFood_Click(object sender, EventArgs e)
        {
            frmPickFood pickFoodForm = new frmPickFood(nameFood, priceFood, idBill, foodCount);
            pickFoodForm.ShowDialog();
        }

        private void uctFood_Click(object sender, EventArgs e)
        {
            frmPickFood pickFoodForm = new frmPickFood(nameFood, priceFood, idBill, foodCount);
            pickFoodForm.ShowDialog();
        }
    }
}
