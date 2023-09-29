using DevExpress.XtraEditors;
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
    public partial class frmAddFood : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext = new QLNHThaiEntities();
        private bool isImageChanged = false;
        public frmAddFood()
        {
            InitializeComponent();
            LoadCategoryData();
        }

        private void LoadCategoryData()
        {
            var categories = dbContext.CategoryFoods.ToList();
            cbbCategory.DataSource = categories;
            cbbCategory.DisplayMember = "name_Category";
            cbbCategory.ValueMember = "id_Category";
        }

        private void imageFood_Click(object sender, EventArgs e)
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
                    imageFood.Image = new Bitmap(imageBitmap);

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
            if (string.IsNullOrWhiteSpace(txbNameFood.Text) || cbbCategory.SelectedItem == null || imageFood.Image == null)
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (nmrPriceFood.Value <= 0)
            {
                XtraMessageBox.Show("Vui lòng nhập giá hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbbCondition.SelectedItem == null)
            {
                XtraMessageBox.Show("Vui lòng cho biết sản phẩm có được bán liền hay không.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Tạo một đối tượng Food mới
            Food newFood = new Food
            {
                name_Food = txbNameFood.Text,
                id_Category = (int)cbbCategory.SelectedValue,
                image_Food = isImageChanged ? ConvertImageToByteArray(imageFood.Image) : null,
                condition_Food = cbbCondition.Text,
                price_Food = (double)nmrPriceFood.Value // Chuyển đổi từ decimal sang double
            };

            // Thêm đối tượng mới vào cơ sở dữ liệu
            try
            {
                dbContext.Foods.Add(newFood);
                dbContext.SaveChanges();

                XtraMessageBox.Show("Thêm món ăn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (Application.OpenForms["frmFood"] is frmFood foodForm)
                {
                    foodForm.LoadFoodData(); // Giả sử tên phương thức là LoadFoodData()
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm món ăn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}