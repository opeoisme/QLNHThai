using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang.GUI_ADD
{
    public partial class frmAddIngredient : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext = new QLNHThaiEntities();
        private bool isImageChanged = false;
        public frmAddIngredient()
        {
            InitializeComponent();
            LoadCatalogData();
        }
        private void LoadCatalogData()
        {
            var catalogs = dbContext.CatalogIngredients.ToList();
            cbbCatalog.DataSource = catalogs;
            cbbCatalog.DisplayMember = "name_Catalog";
            cbbCatalog.ValueMember = "id_Catalog";
        }

        private void imageIngre_Click(object sender, EventArgs e)
        {
            SelectAndSaveImage();
            isImageChanged = true;
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
                    imageIngre.Image = new Bitmap(imageBitmap);

                    byte[] imageBytes = ConvertImageToByteArray(imageBitmap);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbNameIngre.Text) || cbbCatalog.SelectedItem == null || imageIngre.Image == null)
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nmrPrice_Ingre.Value <= 0)
            {
                XtraMessageBox.Show("Vui lòng nhập giá hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nmrCountKid.Value <= 0)
            {
                XtraMessageBox.Show("Vui lòng nhập số lượng chuyển đổi hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Tạo một đối tượng Food mới
            Ingredient newIngredient = new Ingredient
            {
                name_Ingredient = txbNameIngre.Text,
                id_Catalog = (int)cbbCatalog.SelectedValue,
                image_Ingredient = isImageChanged ? ConvertImageToByteArray(imageIngre.Image) : null,
                countkid_Ingredient = (double)nmrCountKid.Value ,
                unit_Ingredient = txbUnitIngre.Text,
                count_Ingredient = 0,
                status_Ingredient = "Ổn định",
                condition_Ingredient = "Sử dụng",
                unitkid_Ingredient = txbUnitKidIngre.Text,
                price_Ingredient = (float)nmrPrice_Ingre.Value,

            };

            // Thêm đối tượng mới vào cơ sở dữ liệu
            try
            {
                dbContext.Ingredients.Add(newIngredient);
                dbContext.SaveChanges();

                XtraMessageBox.Show("Thêm nguyên liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (Application.OpenForms["frmIngredient"] is frmIngredient ingredientForm)
                {
                    ingredientForm.LoadIngredientData(); // Giả sử tên phương thức là LoadFoodData()
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm nguyên liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}