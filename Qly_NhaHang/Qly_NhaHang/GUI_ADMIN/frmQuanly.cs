using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using Qly_NhaHang.GUI_ADMIN;
using Qly_NhaHang.GUI_RESTORE;
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

        private void btnIngredient_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmIngredient));
        }

        private void btnImport_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmImportCoupon));
        }

        private void btnExport_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmExport));
        }

        private void btnDeleteFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmRestoreFood));
        }

        private void btnDeleteCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmRestoreCategory));
        }

        private void btnDeleteTable_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(FrmRestoreTable));
        }

        

        private void btnCatalog_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmCatalog));
        }

        private void btnDeleteNV_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmRestoreNV));
        }

        private void btnDeleteDiscount_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmRestoreDiscount));
        }

        private void btnRevenue_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmThongKeNgay));
        }

        private void btnDeleteIngredient_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmRestoreIngredient));
        }

        private void btnDeleteCatalog_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmRestoreCatalog));
        }

        private void btnTopFood_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmThongKeFood));
        }

        private void btnRecipe_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRecipe f = new frmRecipe();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnRevenueMonth_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDoanhThuThang));
        }

        private void btnCostPrice_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmThuChiNgay));
        }

        private void btnCostPriceMonth_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmThuChiThang));
        }

        private void btnQuarter_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmDoanhThuQuy));
        }

        private void btnUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmUnit));
        }

        private void btnRestoreUnit_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmRestoreUnit));
        }

        private void btnSupp_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmSupplier));
        }

        private void btnRestoreSupplier_ItemClick(object sender, ItemClickEventArgs e)
        {
            openForm(typeof(frmResstoreSupplier));
        }
    }
}