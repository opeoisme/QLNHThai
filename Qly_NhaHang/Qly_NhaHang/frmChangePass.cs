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
    public partial class frmChangePass : DevExpress.XtraEditors.XtraForm
    {
        public string NewPassword { get; private set; }
        private string nhvien;
        public frmChangePass(string nhvien)
        {
            InitializeComponent();
            this.nhvien = nhvien;
        }
        private bool CheckOldPassword(string oldPassword, string nhvien)
        {
            using (QLNHThaiEntities db = new QLNHThaiEntities())
            {
                var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
                if (nv != null && nv.pass_NV == oldPassword)
                {
                    // Nếu mật khẩu cũ trùng khớp với mật khẩu trong CSDL, trả về true.
                    return true;
                }
            }

            // Nếu mật khẩu cũ không khớp hoặc không tìm thấy trong CSDL, trả về false.
            return false;
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldPassword = txbPassword.Text;
            string newPassword = txbNewPass.Text;
            string confirmedPassword = txbComfirmPass.Text;

            // 1. Kiểm tra xem mật khẩu cũ có khớp với mật khẩu hiện tại trong CSDL không.
            // Nếu không khớp, hiển thị thông báo lỗi.
            if (!CheckOldPassword(oldPassword, nhvien))
            {
                lblStatus.Text = "Mật khẩu cũ không đúng. Vui lòng kiểm tra lại.";
                lblStatus.Visible = true; // Hiển thị thông báo trên Label.
                return; // Thoát khỏi sự kiện và không cập nhật mật khẩu mới.
            }

            // 2. Kiểm tra xác nhận mật khẩu mới.
            if (newPassword != confirmedPassword)
            {
                lblStatus.Text = "Mật khẩu mới và xác nhận mật khẩu không khớp. Vui lòng kiểm tra lại.";
                lblStatus.Visible = true; // Hiển thị thông báo trên Label.
                return; // Thoát khỏi sự kiện và không cập nhật mật khẩu mới.
            }

            // 3. Thực hiện cập nhật mật khẩu mới trong CSDL.
            using (QLNHThaiEntities db = new QLNHThaiEntities())
            {
                var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
                if (nv != null)
                {
                    // Cập nhật mật khẩu mới cho đối tượng NhanVien.
                    nv.pass_NV = newPassword;

                    // Cập nhật đối tượng NhanVien trong CSDL.
                    db.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    // Thông báo cho người dùng và đóng form "frmChangePass".
                    MessageBox.Show("Mật khẩu đã được cập nhật thành công.");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã tương ứng trong CSDL.");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}