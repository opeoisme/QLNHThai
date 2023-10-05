using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
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

namespace Qly_NhaHang.UserControl
{
    public partial class uctIngredient : DevExpress.XtraEditors.XtraUserControl
    {
        private int idImport;
        private string nameIngredient;
        private double priceIngre;
        private string ĐVT;
        private string Unit;
        private double countKid;
        private DateTime HSD;
        private double count;
        public uctIngredient(string nameIngredient , string ĐVT, string Unit, double countKid, int idImport, DateTime? HSD, double count, double priceIngre)
        {
            InitializeComponent();
            this.nameIngredient = nameIngredient;
            lblIngredientName.Text = nameIngredient;
            this.ĐVT = ĐVT;
            this.Unit = Unit;
            this.countKid = countKid;
            if (HSD.HasValue)
            {
                this.HSD = HSD.Value;
            }
            else
            {
              this.HSD = DateTime.Now;
            }
            this.idImport = idImport;
            this.count = count;
            this.priceIngre = priceIngre;
            lblPrice.Text = lblPrice.Text = String.Format("{0:0,0 vnđ}", priceIngre);

            using (var dbContext = new QLNHThaiEntities()) 
            {
                var ingredient = dbContext.Ingredients.FirstOrDefault(i => i.name_Ingredient == nameIngredient);
                if (ingredient != null && ingredient.image_Ingredient != null)
                {
                    using (MemoryStream ms = new MemoryStream(ingredient.image_Ingredient))
                    {
                        imageIngredient.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Load ảnh mặc định từ tài nguyên
                    imageIngredient.Image = Properties.Resources.Food0;
                }
            }
       
        }

        private void imageIngredient_Click(object sender, EventArgs e)
        {
            frmImport_Info pickFoodForm = new frmImport_Info(nameIngredient, Unit, ĐVT, countKid, count, idImport ,HSD, priceIngre );
            pickFoodForm.ShowDialog();
        }
    }
}
