using DevExpress.XtraCharts.GLGraphics.Platform;
using DevExpress.XtraEditors;
using Qly_NhaHang.GUI_ADMIN;
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
    public partial class frmExport : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmExport()
        {
            InitializeComponent();
            InitializeDbContext();
        }
        private void InitializeDbContext()
        {
            dbContext = new QLNHThaiEntities();
        }
        public void LoadImportData()
        {
            var importData = dbContext.Imports
                .Where(a => a.type_Import == "Kiểm tồn")
                .Select(a => new ImportModel
                {
                    id_Import = a.id_Import,
                    date_Import = a.date_Import,
                    id_NV = a.id_NV,
                    status_Import = a.status_Import,
                    //total_Price = a.total_Price != null ? (float)a.total_Price : 0.0f, // Kiểm tra giá trị null trước khi chuyển đổi
                })
                .ToList();

            gctExport.DataSource = importData;
        }

        private void btnLoadExport_Click(object sender, EventArgs e)
        {
            LoadImportData();
        }

        private void frmExport_Load(object sender, EventArgs e)
        {
            LoadImportData();
        }

        private void gvExport_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int selectedId = (int)gvExport.GetRowCellValue(e.RowHandle, "id_Import");
            using (var frmDetail = new frmExportDetail(selectedId))
            {
                frmDetail.ShowDialog();
            }
        }
    }
}