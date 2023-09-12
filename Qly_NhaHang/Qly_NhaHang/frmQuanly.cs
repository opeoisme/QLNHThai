using DevExpress.XtraBars;
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
    public partial class frmQuanly : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmQuanly()
        {
            InitializeComponent();
        }
        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        private void btnFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmFood));
        }

        private void btnCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmCategoryFood));
        }

        private void btnTable_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmTable));
        }

        private void btnAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmNhanVien));
        }

        private void Close_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void frmQuanly_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dl = XtraMessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void btnDiscount_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDiscount));
        }

        private void btnReservation_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmReservation));
        }
    }
}