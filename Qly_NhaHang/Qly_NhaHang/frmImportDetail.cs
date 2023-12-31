using DevExpress.XtraCharts.GLGraphics.Platform;
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

namespace Qly_NhaHang
{
    public partial class frmImportDetail : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        private int selectedImportId;
        public frmImportDetail(int importId)
        {
            InitializeComponent();
            InitializeDbContext();
            selectedImportId = importId;
            lblIDImport.Text = selectedImportId.ToString();

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
                    name_Supplier = a.name_Supplier,
                })
                .ToList();
            gctImportInfo.DataSource = importData;
        }

        private void frmImportDetail_Load(object sender, EventArgs e)
        {
            LoadImportInfoData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn hủy?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var selectedRows = gvImportInfo.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    ImportDetail selectedImportDetail = gvImportInfo.GetRow(rowHandle) as ImportDetail;

                    if (selectedImportDetail != null)
                    {
                        int importInfoId = selectedImportDetail.id_ImportInfo;
                        var importInfo = dbContext.ImportInfoes.FirstOrDefault(i => i.id_ImportInfo == importInfoId);
                        if (importInfo != null)
                        {
                            int ingredientId = selectedImportDetail.id_Ingredient;
                            int countToSubtract = selectedImportDetail.count_Ingredient;
                            importInfo.count_Ingredient -= countToSubtract;
                            var ingredient = dbContext.Ingredients.FirstOrDefault(i => i.id_Ingredient == ingredientId);
                            if (ingredient != null)
                            {
                                ingredient.count_Ingredient -= countToSubtract;
                            }
                        }
                    }
                }
                dbContext.SaveChanges();
                LoadImportInfoData();
            }
        }



    }
}