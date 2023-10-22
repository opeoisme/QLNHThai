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
                    return true;
                }
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string oldPassword = txbPassword.Text;
            string newPassword = txbNewPass.Text;
            string confirmedPassword = txbComfirmPass.Text;
            if (!CheckOldPassword(oldPassword, nhvien))
            {
                lblStatus.Text = "Mật khẩu cũ không đúng. Vui lòng kiểm tra lại.";
                lblStatus.Visible = true; 
                return; 
            }
            if (newPassword != confirmedPassword)
            {
                lblStatus.Text = "Mật khẩu mới và xác nhận mật khẩu không khớp. Vui lòng kiểm tra lại.";
                lblStatus.Visible = true; 
                return; 
            }
            using (QLNHThaiEntities db = new QLNHThaiEntities())
            {
                var nv = db.NhanViens.Where(nhanvien => nhanvien.id_NV == nhvien).FirstOrDefault();
                if (nv != null)
                {
                    nv.pass_NV = newPassword;
                    db.Entry(nv).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    XtraMessageBox.Show("Mật khẩu đã được cập nhật thành công.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên có mã tương ứng trong CSDL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.CheckState == CheckState.Unchecked)
            {
                txbPassword.PasswordChar = '\0';
            }
            else
            {
                txbPassword.PasswordChar = '*';
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
    }
}