using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TextEditController.Win32;

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
using System.Xml.Linq;
using static DevExpress.Utils.Filtering.ExcelFilterOptions;


namespace Qly_NhaHang
{
    public partial class frmProfileNV : DevExpress.XtraEditors.XtraForm
    {
        private NhanVien nhanVien;
        private String nhvien = "";
        private bool isImageChanged = false;
        public frmProfileNV(NhanVien nhv)
        {

            InitializeComponent();
            this.nhanVien = nhv;
            this.nhvien = nhv.id_NV;
            LoadProfile();
        }

        public void LoadProfile()
        {
            using (QLNHThaiEntities db = new QLNHThaiEntities())
            {
                var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
                if (nv != null)
                {
                    txbFullName.Text = nv.name_NV;
                    txbMaNV.Text = nv.id_NV;
                    txbCCCD.Text = nv.CCCD_NV;
                    txbSexNV.Text = nv.sex_NV;
                    txbAddress.Text = nv.address_NV;
                    txbSDT.Text = nv.phone_NV;
                    txbPosition.Text = nv.type_NV;
                    if (nv.image_NV != null)
                    {
                        byte[] imageBytes = nv.image_NV;
                        Image image = Base64ToImage(imageBytes);
                        ptbNV.Image = image;
                    }
                }
            }
        }


        private void dtpkBirthDay_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public byte[] ImageToBase64(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }
        public Image Base64ToImage(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string diaChi = txbAddress.Text;
            using (QLNHThaiEntities db = new QLNHThaiEntities())
            {
                var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
                if (nv != null)
                {
                    nv.address_NV = diaChi;
                    if (ptbNV.Image != null && isImageChanged)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            ptbNV.Image.Save(ms, ImageFormat.Jpeg);
                            byte[] codeimage = ms.ToArray();
                            nv.image_NV = codeimage;
                        }
                    }

                    db.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    XtraMessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isImageChanged = false;
                    LoadProfile();
                }
                else
                {
                    XtraMessageBox.Show("Không tìm thấy nhân viên có mã tương ứng trong CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ptbNV_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;";
            DialogResult choose = open.ShowDialog();

            if (choose == DialogResult.OK)
            {
                string path = open.FileName;
                Bitmap bt = new Bitmap(Image.FromFile(path));
                ptbNV.Image = bt;
                byte[] codeimage = ImageToBase64(bt, ImageFormat.Jpeg);
                using (QLNHThaiEntities db = new QLNHThaiEntities())
                {
                    var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
                    if (nv != null)
                    {
                        nv.image_NV = codeimage;
                        isImageChanged = true;
                        db.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                        XtraMessageBox.Show("Cập nhật thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            using (frmChangePass changePassForm = new frmChangePass(nhvien))
            {
                if (changePassForm.ShowDialog() == DialogResult.OK)
                {
                    XtraMessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}   