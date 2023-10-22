using DevExpress.XtraEditors;
using Qly_NhaHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang.GUI_ADMIN
{
    public partial class frmExportDetail : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        private int selectedImportId;
        public frmExportDetail(int importId)
        {
            InitializeComponent();
            InitializeDbContext();
            selectedImportId = importId;
            lblIDExport.Text = selectedImportId.ToString();
        }

        private void InitializeDbContext()
        {
            dbContext = new QLNHThaiEntities();
        }

        public void LoadImportInfoData()
        {
            var importData = dbContext.ImportInfoes
                 .Where(a => a.id_Import == selectedImportId)
                .Select(a => new ImportDetail
                {
                    id_ImportInfo = a.id_ImportInfo,
                    id_Import = a.id_Import,
                    count_Ingredient = a.count_Ingredient,
                    date_Expiry = a.date_Expiry,
                    id_Ingredient = a.id_Ingredient,
                })
                .ToList();

            gctExportInfo.DataSource = importData;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExportDetail_Load(object sender, EventArgs e)
        {
            LoadImportInfoData();
        }
    }
}