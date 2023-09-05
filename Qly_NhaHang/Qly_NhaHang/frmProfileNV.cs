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

            // Hiển thị thông tin trong các controls


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
            // Lấy dữ liệu từ các control
            string diaChi = txbAddress.Text;

            // Thực hiện lưu dữ liệu vào CSDL
            using (QLNHThaiEntities db = new QLNHThaiEntities())
            {
                var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
                if (nv != null)
                {
                    nv.address_NV = diaChi;

                    // Chỉ cập nhật ảnh nếu ptbNV.Image không null và đã thay đổi ảnh
                    if (ptbNV.Image != null && isImageChanged)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            // Lưu ảnh trực tiếp vào MemoryStream
                            ptbNV.Image.Save(ms, ImageFormat.Jpeg);

                            // Chuyển đổi từ MemoryStream thành mảng byte
                            byte[] codeimage = ms.ToArray();

                            // Cập nhật dữ liệu hình ảnh
                            nv.image_NV = codeimage;
                        }
                    }

                    db.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Dữ liệu đã được lưu thành công!");

                    // Đặt lại biến isImageChanged về false sau khi lưu
                    isImageChanged = false;

                    // Gọi lại phương thức LoadProfile để cập nhật dữ liệu trên form
                    LoadProfile();
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

                        // Đánh dấu là đã thay đổi ảnh
                        isImageChanged = true;

                        // Cập nhật dữ liệu và lưu vào CSDL
                        db.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
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
                    // Sau khi cập nhật mật khẩu thành công, bạn có thể thực hiện các hành động khác tại đây.
                }
            }
        }

    }
}   