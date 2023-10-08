using DevExpress.XtraEditors;
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
    public partial class frmDetailRecipe : DevExpress.XtraEditors.XtraForm
    {
        private int ingredientCount;
        private int quantity;
        private int idFood;

        public frmDetailRecipe(string nameIngredient, string unitIngredient, int ingredientCount, int idFood)
        {
            
            InitializeComponent();
            lblNameIngre.Text = nameIngredient;
            lblUnit.Text = unitIngredient;
            this.ingredientCount = ingredientCount;
            nmrQuantity.Value = ingredientCount;
            this.idFood = idFood;
            lblID.Text = idFood.ToString();

        }
        private int GetIngredientIdByName(string nameIngredient)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var ingredient = dbContext.Ingredients.FirstOrDefault(f => f.name_Ingredient == nameIngredient);
                if (ingredient != null)
                {
                    return ingredient.id_Ingredient;
                }
                return -1; // Trả về một giá trị không hợp lệ nếu không tìm thấy món ăn
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                int idIngredient = GetIngredientIdByName(lblNameIngre.Text);
                string idFoodText = lblID.Text;
               int idFoodValue = int.Parse(idFoodText);


                Recipe existingRecipe = dbContext.Recipes
                    .FirstOrDefault(bi => bi.id_Food == idFoodValue && bi.id_Ingredient == idIngredient);

                if (existingRecipe == null)
                {
                    // Tạo mới một BillInfo nếu không tồn tại
                    if (ingredientCount == 0 && quantity == 0)
                    {
                        XtraMessageBox.Show("Vui lòng nhập số lượng món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (ingredientCount == 0)
                        {
                            Recipe newRecipe = new Recipe
                            {
                                id_Food = idFoodValue,
                                id_Ingredient = idIngredient,
                                count_Ingredient = quantity,
                            };
                            dbContext.Recipes.Add(newRecipe);
                            dbContext.SaveChanges();
                        }
                    }
                }
                else
                {
                    if (nmrQuantity.Value == 0)
                    {
                        // Xóa BillInfo nếu foodCount bằng 0
                        dbContext.Recipes.Remove(existingRecipe);
                    }
                    else
                    {
                        // Cập nhật count_Food nếu foodCount khác 0
                        existingRecipe.count_Ingredient = quantity;
                    }
                }

                dbContext.SaveChanges();

                this.Close();
                if (Application.OpenForms["frmRecipe"] is frmRecipe recipeForm)
                {
                    recipeForm.LoadDataRecipe(); // Giả sử tên phương thức là LoadFoodData()

                    recipeForm.GetIngredientCount(ingredientCount);
                    recipeForm.LoadIngredientFLPNTest();
                }

            }
        }

        private void nmrQuantity_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int)nmrQuantity.Value;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}