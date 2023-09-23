using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Qly_NhaHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmCatalog : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmCatalog()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
            InitializeGridViewOptions();
        }
        private void InitializeGridViewOptions()
        {
            GridView gridView = gctCatalog.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvCatalog_FocusedRowChanged;
        }
        public void LoadFormCatalog()
        {
            var catalogData = dbContext.CatalogIngredients
                             .Where(ct => ct.condition_Catalog == "Sử dụng")
                            .Select(ct => new CatalogView
                            {
                                id_Catalog = ct.id_Catalog,
                                name_Catalog = ct.name_Catalog,
                                condition_Catalog = ct.condition_Catalog,
                            }).ToList();
            gctCatalog.DataSource = catalogData;
        }
        private void btnLoadCatalog_Click(object sender, EventArgs e)
        {
            LoadFormCatalog();
        }

        private void gvCatalog_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateCatalogControls(e.FocusedRowHandle);
            }
        }
        private void UpdateCatalogControls(int focusedRowHandle)
        {
            CatalogView selectedCatalog = gvCatalog.GetRow(focusedRowHandle) as CatalogView;
            if (selectedCatalog != null)
            {
                txbIdCatalog.Text = selectedCatalog.id_Catalog.ToString();
                txbNameCatalog.Text = selectedCatalog.name_Catalog;
                cbbConditionCatalog.Text = selectedCatalog.condition_Catalog.ToString();

            }
        }

        private void frmCatalog_Load(object sender, EventArgs e)
        {
            LoadFormCatalog();
        }
    }
}