using DevExpress.XtraEditors;
using DevExpress.XtraEditors.TextEditController.Win32;
using Qly_NhaHang.DAO;
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
        public frmProfileNV(NhanVien nhv)
        {

            InitializeComponent();
            this.nhanVien = nhv;
            this.nhvien = nhv.id_NV;
            LoadProfile();

            // Hiển thị thông tin trong các controls


        }

        public void LoadProfile()
        {
            txbFullName.Text = nhanVien.name_NV;
            txbMaNV.Text = nhanVien.id_NV;
            txbCCCD.Text = nhanVien.CCCD_NV;
            txbSexNV.Text = nhanVien.sex_NV;
            txbAddress.Text = nhanVien.address_NV;
            txbSDT.Text = nhanVien.phone_NV;
            txbPosition.Text = nhanVien.type_NV;


            //using (QLNHThaiEntities db = new QLNHThaiEntities())
            //{
            //    var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
            //    if (nv != null && nv.image_NV != null)
            //    {
            //        byte[] imageBytes = nv.image_NV;
            //        Image image = Base64ToImage(imageBytes);
            //        ptbImageNV.Image = image;
            //    }
            //}


            using (QLNHThaiEntities db = new QLNHThaiEntities())
            {
                var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
                if (nv != null && nv.image_NV != null)
                {
                    byte[] imageBytes = nv.image_NV;
                    Image image = Base64ToImage(imageBytes);
                    ptbNV.Image = image;
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.CheckState == CheckState.Unchecked)
            {
                txbPassword.PasswordChar = '*';
            }
            else
            {
                txbPassword.PasswordChar = '\0';
            }
        }

        private void checkBoxShowHide_MouseHover(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.IsBalloon = true;
            t.ToolTipIcon = ToolTipIcon.Info;
            t.ShowAlways = true;
            if (checkBoxShowHide.CheckState == CheckState.Checked)
            {
                t.SetToolTip(checkBoxShowHide, "Ẩn mật khẩu");
            }
            else
            {
                t.SetToolTip(checkBoxShowHide, "Hiện mật khẩu");
            }
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

        private void ptbImageNV_Click(object sender, EventArgs e)
        {
            //OpenFileDialog open = new OpenFileDialog();
            //open.Filter = "Image Files|*.jpg;*.jpeg;";
            //DialogResult choose = open.ShowDialog();

            //if (choose == DialogResult.OK)
            //{
            //    string path = open.FileName;
            //    Bitmap bt = new Bitmap(Image.FromFile(path));

            //    //-- Xuất ra pictureBox 
            //    ptbImageNV.Image = bt;

            //    byte[] codeimage = ImageToBase64(bt, ImageFormat.Jpeg);

            //    using (QLNHThaiEntities db = new QLNHThaiEntities())
            //    {
            //        var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
            //        if (nv != null)
            //        {
            //            // Lưu dữ liệu hình ảnh vào cơ sở dữ liệu
            //            nv.image_NV = codeimage;

            //            // Cập nhật dữ liệu và lưu vào CSDL
            //            db.Entry(nv).State = System.Data.Entity.EntityState.Modified;
            //            db.SaveChanges();
            //        }
            //    }
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các control
            string diaChi = txbAddress.Text;

            // Lấy dữ liệu hình ảnh từ pictureBox
            Image hinhAnh = ptbNV.Image;
            byte[] codeimage = ImageToBase64(hinhAnh, ImageFormat.Jpeg);

            // Thực hiện lưu dữ liệu vào CSDL
            using (QLNHThaiEntities db = new QLNHThaiEntities())
            {
                var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
                if (nv != null)
                {
                    nv.address_NV = diaChi;
                    nv.image_NV = codeimage;

                    db.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Dữ liệu đã được lưu thành công!");
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã tương ứng trong CSDL.");
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

                //-- Xuất ra pictureBox 
                ptbNV.Image = bt;

                byte[] codeimage = ImageToBase64(bt, ImageFormat.Jpeg);

                using (QLNHThaiEntities db = new QLNHThaiEntities())
                {
                    var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
                    if (nv != null)
                    {
                        // Lưu dữ liệu hình ảnh vào cơ sở dữ liệu
                        nv.image_NV = codeimage;

                        // Cập nhật dữ liệu và lưu vào CSDL
                        db.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}   