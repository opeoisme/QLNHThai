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
            // Kiểm tra xem người dùng có muốn xóa hay không
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Lấy danh sách các hàng đã chọn
                var selectedRows = gvImportInfo.GetSelectedRows();

                foreach (var rowHandle in selectedRows)
                {
                    // Lấy đối tượng ImportDetail tương ứng với hàng đã chọn
                    ImportDetail selectedImportDetail = gvImportInfo.GetRow(rowHandle) as ImportDetail;

                    if (selectedImportDetail != null)
                    {
                        // Lấy id_ImportInfo của hàng đã chọn
                        int importInfoId = selectedImportDetail.id_ImportInfo;

                        // Truy vấn và cập nhật dữ liệu trong bảng ImportInfo
                        var importInfo = dbContext.ImportInfoes.FirstOrDefault(i => i.id_ImportInfo == importInfoId);

                        if (importInfo != null)
                        {
                            // Lấy thông tin id_Ingredient và count_Ingredient từ bảng ImportDetail
                            int ingredientId = selectedImportDetail.id_Ingredient;
                            int countToSubtract = selectedImportDetail.count_Ingredient;

                            // Trừ giá trị hiện tại của count_Ingredient từ chính nó để đạt giá trị 0
                            importInfo.count_Ingredient -= countToSubtract;

                            // Truy vấn và cập nhật dữ liệu trong bảng Ingredient
                            var ingredient = dbContext.Ingredients.FirstOrDefault(i => i.id_Ingredient == ingredientId);

                            if (ingredient != null)
                            {
                                ingredient.count_Ingredient -= countToSubtract;
                            }
                        }
                    }
                }
                dbContext.SaveChanges();

                // Sau khi cập nhật xong, làm mới dữ liệu trên GridControl
                LoadImportInfoData();
            }
        }



    }
}