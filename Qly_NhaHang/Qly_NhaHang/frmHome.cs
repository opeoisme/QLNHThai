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
    public partial class frmHome : DevExpress.XtraEditors.XtraForm
    {
        bool sidebarExpand;
        bool homeCollapsed;

        private NhanVien nhanVien;
        public frmHome(NhanVien nhv)
        {
            InitializeComponent();
            nhanVien = nhv;

            lbNameNV.Text = nhanVien.name_NV;

            if (nhanVien.type_NV == "Quản lý")
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }
        }

        public void UpdateNameNV(string name_NV)
        {
            lbNameNV.Text =  name_NV;
        }
        public void UpdateButtonVisibility(string type_NV)
        {
            if (type_NV == "Quản lý")
            {
                btnAdmin.Visible = true;
            }
            else
            {
                btnAdmin.Visible = false;
            }
        }

        #region method
        // keo ngang thanh sidebar
        private void sidebarTime_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTime.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar .MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTime.Stop();
                }
            }
        }

        // keo doc nut home
        private void HomeTime_Tick(object sender, EventArgs e)
        {
            if (homeCollapsed)
            {
                HomeContainer.Height += 10;
                if (HomeContainer.Height == HomeContainer.MaximumSize.Height)
                {
                    homeCollapsed = false;
                    HomeTime.Stop();
                }
            }
            else
            {
                HomeContainer.Height -= 10;
                if (HomeContainer.Height == HomeContainer.MinimumSize.Height)
                {
                    homeCollapsed = true;
                    HomeTime.Stop();
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
            DateTime now = DateTime.Now;
            labelDay.Text = now.ToString("dddd");
            labelDate.Text = now.ToString("dd/MM/yyyy");
        }
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            if (IsHandleCreated)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    lblTime.Text = DateTime.Now.ToString("T");
                }));
            }
        }

        #endregion

        #region event
        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTime.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeTime.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = XtraMessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            frmListTable f = new frmListTable();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            frmProfileNV p = new frmProfileNV(nhanVien);
            this.Hide();
            p.ShowDialog();
            this.Show();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmQuanly f = new frmQuanly();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Chức năng đang được cập nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Chức năng đang được cập nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Chức năng đang được cập nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        #endregion


    }
}