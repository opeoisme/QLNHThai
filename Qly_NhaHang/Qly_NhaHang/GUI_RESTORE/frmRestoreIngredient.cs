using DevExpress.XtraEditors;
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
    public partial class frmRestoreIngredient : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmRestoreIngredient()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
            LoadCategoryData();
        }

        private void LoadCategoryData()
        {
            var catalog = dbContext.CatalogIngredients.ToList();
            cbbCatalog.DataSource = catalog;
            cbbCatalog.DisplayMember = "name_Catalog";
            cbbCatalog.ValueMember = "id_Catalog";
        }

        public void LoadIngredientData()
        {
            var ingredientData = dbContext.Ingredients
                .Join(
                    dbContext.CatalogIngredients,
                    ingredient => ingredient.id_Catalog,
                    catalog => catalog.id_Catalog,
                    (ingredient, catalog) => new { Ingredient = ingredient, Catalog = catalog }
                )
                .Where(joinResult => joinResult.Ingredient.condition_Ingredient == "Ngừng sử dụng" || joinResult.Catalog.condition_Catalog == "Ngừng sử dụng")
                .Select(joinResult => new IngredientView
                {
                    id_Ingredient = joinResult.Ingredient.id_Ingredient,
                    name_Ingredient = joinResult.Ingredient.name_Ingredient,
                    unit_Ingredient = joinResult.Ingredient.unit_Ingredient,
                    count_Ingredient = (float)joinResult.Ingredient.count_Ingredient,
                    status_Ingredient = joinResult.Ingredient.status_Ingredient,
                    condition_Ingredient = joinResult.Ingredient.condition_Ingredient,
                    image_Ingredient = joinResult.Ingredient.image_Ingredient,
                    id_Catalog = (int)joinResult.Ingredient.id_Catalog,
                    countkid_Ingredient = (float)joinResult.Ingredient.countkid_Ingredient,
                    unitkid_Ingredient = joinResult.Ingredient.unitkid_Ingredient,
                })
                .ToList();
            gctIngredient.DataSource = ingredientData;
        }

        private void frmRestoreIngredient_Load(object sender, EventArgs e)
        {
            LoadIngredientData();
        }

        private void btnLoadIngredient_Click(object sender, EventArgs e)
        {
            LoadIngredientData();
        }

        private void gvIngredient_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateIngredientControls(e.FocusedRowHandle);
            }
        }

        private void UpdateIngredientControls(int focusedRowHandle)
        {
            IngredientView selectedIngredient = gvIngredient.GetRow(focusedRowHandle) as IngredientView;
            if (selectedIngredient != null)
            {
                txbIdIngredient.Text = selectedIngredient.id_Ingredient.ToString();
                txbNameIngredient.Text = selectedIngredient.name_Ingredient;
                cbbCatalog.SelectedValue = selectedIngredient.id_Catalog;
                cbbConditionIngredient.Text = selectedIngredient.condition_Ingredient;
                nmrCountKid.Value = (decimal)selectedIngredient.countkid_Ingredient;
                nmrCountIngredient.Value = (decimal)selectedIngredient.count_Ingredient;
                cbbStatusIngredient.Text = selectedIngredient.status_Ingredient;
                cbbUnitKid.Text = selectedIngredient.unitkid_Ingredient;
                cbbUnitIngredient.Text = selectedIngredient.unit_Ingredient;
                if (selectedIngredient.image_Ingredient != null)
                {
                    using (MemoryStream ms = new MemoryStream(selectedIngredient.image_Ingredient))
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

        private void btnReloadIngredient_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvIngredient.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                IngredientView selectedIngredient = gvIngredient.GetRow(focusedRowHandle) as IngredientView;
                if (selectedIngredient != null)
                {
                    if (int.TryParse(selectedIngredient.id_Ingredient.ToString(), out int ingredientId))
                    {
                        Ingredient ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(i => i.id_Ingredient == ingredientId);

                        if (ingredientToUpdate != null)
                        {
                            ingredientToUpdate.condition_Ingredient = "Sử dụng";

                            // Đánh dấu đối tượng là thay đổi
                            dbContext.Entry(ingredientToUpdate).State = EntityState.Modified;

                            // Lưu thay đổi
                            dbContext.SaveChanges();

                            // Nạp lại dữ liệu sau khi cập nhật
                            LoadIngredientData();
                            XtraMessageBox.Show("Nguyên liệu được đưa vào sử dụng lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}