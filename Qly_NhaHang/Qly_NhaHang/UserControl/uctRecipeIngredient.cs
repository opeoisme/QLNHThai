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
    public partial class uctRecipeIngredient : DevExpress.XtraEditors.XtraUserControl
    {
        private int idFood;
        public string nameIngredient;
        private int ingredientCount;
        private string unitIngredient;

        public uctRecipeIngredient(string nameIngredient, string unitIngredient, int ingredientCount, int idFood)
        {
            InitializeComponent();
            this.nameIngredient = nameIngredient;
            lblIngredientName.Text = nameIngredient;
            this.unitIngredient = unitIngredient;
            this.ingredientCount = ingredientCount;
            this.idFood = idFood;



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
                    imageIngredient.Image = Properties.Resources.Food0;
                }
            }
        }

        private void imageIngredient_Click(object sender, EventArgs e)
        {
            frmDetailRecipe pickFoodForm = new frmDetailRecipe(nameIngredient, unitIngredient, ingredientCount, idFood);
            pickFoodForm.ShowDialog();
        }
    }
}
