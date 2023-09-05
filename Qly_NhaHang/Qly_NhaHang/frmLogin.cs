using DevExpress.Utils.Win.Hook;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Qly_NhaHang
{
    public partial class frmLogin : Form
    {
        private QLNHThaiEntities dbContext;
        public static string LoggedInIdNV { get; private set; }
        public frmLogin()
        {
          InitializeComponent();
          dbContext = new QLNHThaiEntities();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadFormData()
        {
            // Thực hiện tải lại dữ liệu từ cơ sở dữ liệu và cập nhật danh sách tài khoản NhanVien
            dbContext = new QLNHThaiEntities();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string idNV = txbMaNV.Text;
            string password = txbPassword.Text;
            var nhanvien = dbContext.NhanViens.FirstOrDefault(u => u.id_NV == idNV && u.pass_NV == password);

            if (nhanvien != null && nhanvien.condition_NV == "Làm việc")
            {
                // Đăng nhập thành công
                LoggedInIdNV = idNV;
                MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFormData();
                nhanvien.name_NV = nhanvien.name_NV.ToString();
                nhanvien.type_NV = nhanvien.type_NV.ToString();
                frmHome f = new frmHome(nhanvien);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (nhanvien != null && nhanvien.condition_NV != "Làm việc")
            {
                // Người dùng đã nghỉ việc
                MessageBox.Show("Tài khoản này đã nghỉ việc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLogin_Enter(object sender, KeyEventArgs e)
        {
           
        }
        private void checkBoxShowHide_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            
        }
        private void checkBoxShowHide_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void chkShowHide_CheckedChanged(object sender, EventArgs e)
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
        private void checkBoxShowHide_MouseHover_1(object sender, EventArgs e)
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
