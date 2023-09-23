using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
using Qly_NhaHang.Models;
using Qly_NhaHang.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmIngredient : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        private bool isImageChanged = false;
        public frmIngredient()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
            LoadCategoryData();
        }
        private void btnLoadIngredient_Click(object sender, EventArgs e)
        {
            LoadIngredientData();
        }

        private void frmIngredient_Load(object sender, EventArgs e)
        {
            LoadIngredientData();
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
                .Where(joinResult => joinResult.Ingredient.condition_Ingredient == "Sử dụng" && joinResult.Catalog.condition_Catalog == "Sử dụng")
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






        private void SelectAndSaveImage()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;";
            DialogResult choose = open.ShowDialog();

            if (choose == DialogResult.OK)
            {
                string imagePath = open.FileName;

                using (Bitmap imageBitmap = new Bitmap(Image.FromFile(imagePath)))
                {
                    imageIngredient.Image = new Bitmap(imageBitmap);

                    byte[] imageBytes = ConvertImageToByteArray(imageBitmap);
                    if (imageBytes != null)
                    {
                        UpdateIngredientImageInDatabase(imageBytes);
                    }
                }
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    image.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi khi chuyển đổi hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void UpdateIngredientImageInDatabase(byte[] imageBytes)
        {
            if (int.TryParse(txbIdIngredient.Text, out int selectedIngredientId))
            {
                Ingredient ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(ingredient => ingredient.id_Ingredient == selectedIngredientId);

                if (ingredientToUpdate != null)
                {
                    ingredientToUpdate.image_Ingredient = imageBytes;
                    dbContext.Entry(ingredientToUpdate).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
            }
        }

        private void UpdateIngredientProperties(Ingredient ingredient)
        {
            ingredient.name_Ingredient = txbNameIngredient.Text;
            ingredient.id_Catalog = Convert.ToInt32(cbbCatalog.SelectedValue);
            ingredient.condition_Ingredient = cbbConditionIngredient.SelectedItem?.ToString();
            ingredient.count_Ingredient = (float)nmrCountIngredient.Value;
            ingredient.countkid_Ingredient = (float)nmrCountKid.Value;
            ingredient.status_Ingredient = cbbStatusIngredient.SelectedItem?.ToString();
            ingredient.unitkid_Ingredient = cbbUnitKid.SelectedItem?.ToString();
            ingredient.unit_Ingredient = cbbUnitIngredient.SelectedItem?.ToString();


        }

        private void UpdateIngredientImage(Ingredient ingredientToUpdate)
        {
            byte[] imageBytes = ConvertImageToByteArray(imageIngredient.Image);
            if (imageBytes != null)
            {
                ingredientToUpdate.image_Ingredient = imageBytes;
                dbContext.SaveChanges();
            }
        }

        private void imageIngredient_Click(object sender, EventArgs e)
        {
            SelectAndSaveImage();
            isImageChanged = true;
        }

        private void btnUpdateIngredient_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbIdIngredient.Text, out int ingredientId))
            {
                Ingredient ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(i => i.id_Ingredient == ingredientId);

                if (ingredientToUpdate != null)
                {
                    UpdateIngredientProperties(ingredientToUpdate);

                    dbContext.Entry(ingredientToUpdate).State = EntityState.Modified;

                    if (isImageChanged && imageIngredient.Image != null)
                    {
                        UpdateIngredientImage(ingredientToUpdate);
                    }
                    dbContext.SaveChanges();
                    LoadIngredientData();
                    XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            isImageChanged = false;
        }
    }
}