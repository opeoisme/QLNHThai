using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmAddNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext = new QLNHThaiEntities();
        private bool isImageChanged = false;
        public frmAddNhanVien()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void imageNhanVien_Click(object sender, EventArgs e)
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
                    imageNhanVien.Image = new Bitmap(imageBitmap);

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

        private bool IsNumeric(string value)
        {
            return int.TryParse(value, out _);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbIDNhanVien.Text) || string.IsNullOrWhiteSpace(txbFullName.Text) || cbbSex.SelectedItem == null || imageNhanVien.Image == null ||  string.IsNullOrWhiteSpace(txbPhone.Text) || string.IsNullOrWhiteSpace(txbAddressNV.Text) || string.IsNullOrWhiteSpace(txbCCCD.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dbContext.NhanViens.Any(nv => nv.id_NV == txbIDNhanVien.Text))
            {
                XtraMessageBox.Show("Đổi lại mã nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string phoneNumber = txbPhone.Text;
            if (phoneNumber.Length != 10 || !IsNumeric(phoneNumber))
            {
                XtraMessageBox.Show("Số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cccd = txbCCCD.Text;
            if (cccd.Length != 12 || !IsNumeric(cccd))
            {
                XtraMessageBox.Show("Căn cước công dân không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            NhanVien newNhanvien = new NhanVien
            {
                id_NV = txbIDNhanVien.Text,
                name_NV = txbFullName.Text,
                CCCD_NV = txbCCCD.Text,
                phone_NV = txbPhone.Text,
                address_NV = txbAddressNV.Text,
                sex_NV = cbbSex.Text,
                image_NV = isImageChanged ? ConvertImageToByteArray(imageNhanVien.Image) : null,
                condition_NV = "Làm việc",
                pass_NV = "1", 
                type_NV = "Nhân viên" 
            };
            try
            {
                dbContext.NhanViens.Add(newNhanvien);
                dbContext.SaveChanges();

                XtraMessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (Application.OpenForms["frmNhanVien"] is frmNhanVien nhanvienForm)
                {
                    nhanvienForm.LoadFormNV();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi thêm mới thông tin!!! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}