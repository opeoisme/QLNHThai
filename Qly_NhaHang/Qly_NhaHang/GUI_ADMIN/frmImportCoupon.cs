using DevExpress.XtraEditors;
using Qly_NhaHang.Models;
using Qly_NhaHang.UserControl;
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
    public partial class frmImportCoupon : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmImportCoupon()
        {
            InitializeComponent();
            InitializeDbContext();
            UpdateImportStatus();
        }
        private void InitializeDbContext()
        {
            dbContext = new QLNHThaiEntities();
        }

        public void LoadImportData()
        {
            var importData = dbContext.Imports
                .Where(a => a.type_Import == "Nhập hàng" )
                .Select(a => new ImportModel
                {
                    id_Import = a.id_Import,
                    date_Import = a.date_Import,
                    id_NV = a.id_NV,
                    status_Import = a.status_Import,
                    total_Price = (float)a.total_Price,
                })
                .ToList();

            gctImport.DataSource = importData;
        }

        private void btnLoadImport_Click(object sender, EventArgs e)
        {
            LoadImportData();
            UpdateImportStatus();
        }

        private void frmImportCoupon_Load(object sender, EventArgs e)
        {
            LoadImportData();
        }

        private void gvImport_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int selectedId = (int)gvImport.GetRowCellValue(e.RowHandle, "id_Import");
            using (var frmDetail = new frmImportDetail(selectedId))
            {
                frmDetail.ShowDialog();
            }
        }









        private void UpdateImportStatus()
        {
            DateTime currentDate = DateTime.Today.AddDays(1); // Ngày hiện tại + 1 ngày

            // Lấy danh sách các id_Ingredient có ít nhất một Import_Info có date_Expiry hơn ngày hiện tại + 1 ngày và count_Ingredient > 0
            var candate = dbContext.ImportInfoes
                .Where(info => info.date_Expiry == currentDate && info.count_Ingredient > 0)
                .Select(info => info.id_Import)
                .Distinct()
                .ToList();

            // Lấy danh sách các id_Ingredient có ít nhất một Import_Info có date_Expiry hơn ngày hiện tại + 2 ngày và count_Ingredient > 0
            var ondinh = dbContext.ImportInfoes
                .Where(info => info.date_Expiry >= currentDate && info.count_Ingredient >= 0)
                .Select(info => info.id_Import)
                .Distinct()
                .ToList();

            // Lấy danh sách các id_Ingredient có ít nhất một Import_Info có date_Expiry bằng ngày hiện tại và count_Ingredient > 0
            var hetdate = dbContext.ImportInfoes
                .Where(info => info.date_Expiry < currentDate && info.count_Ingredient > 0)
                .Select(info => info.id_Import)
                .Distinct()
                .ToList();

            // Lấy danh sách các id_Ingredient có cả "Có hàng sắp hết hạn" và "Có hàng hết hạn"
            var hethancandate = candate
                .Where(id => hetdate.Contains(id))
                .ToList();


            foreach (var ingredientId in ondinh)
            {
                // Tìm nguyên liệu tương ứng trong bảng Ingredients
                var ingredientToUpdate = dbContext.Imports.FirstOrDefault(ingredient => ingredient.id_Import == ingredientId);

                if (ingredientToUpdate != null)
                {
                    // Ưu tiên trạng thái "Ổn định"
                    ingredientToUpdate.status_Import = "Ổn định";
                }
            }

            foreach (var ingredientId in candate)
            {
                // Tìm nguyên liệu tương ứng trong bảng Ingredients
                var ingredientToUpdate = dbContext.Imports.FirstOrDefault(ingredient => ingredient.id_Import == ingredientId);

                if (ingredientToUpdate != null)
                {
                    // Ưu tiên trạng thái "Có hàng sắp hết hạn"
                    ingredientToUpdate.status_Import = "Có hàng cận date";
                }
            }

            foreach (var ingredientId in hetdate)
            {
                // Tìm nguyên liệu tương ứng trong bảng Ingredients
                var ingredientToUpdate = dbContext.Imports.FirstOrDefault(ingredient => ingredient.id_Import == ingredientId);

                if (ingredientToUpdate != null)
                {
                    // Ưu tiên trạng thái "Có hàng hết hạn"
                    ingredientToUpdate.status_Import = "Có hàng hết date";
                }
            }

            foreach (var ingredientId in hethancandate)
            {
                // Tìm nguyên liệu tương ứng trong bảng Ingredients
                var ingredientToUpdate = dbContext.Imports.FirstOrDefault(ingredient => ingredient.id_Import == ingredientId);

                if (ingredientToUpdate != null)
                {
                    // Đặt trạng thái "Có hàng cận date và đã hết hạn"
                    ingredientToUpdate.status_Import = "Có hàng cận date và hết hạn";
                }
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            dbContext.SaveChanges();
        }

        private void gvImport_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "status_Import" && e.CellValue != null)
            {
                string status = e.CellValue.ToString();

                // Kiểm tra nếu trạng thái là "Ổn định" thì đặt màu nền là màu xanh lá
                if (status == "Có hàng hết date")
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.ForeColor = Color.Red; // Đặt màu chữ
                }
                if (status == "Có hàng cận date và hết hạn")
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.ForeColor = Color.DarkRed; // Đặt màu chữ
                }
                if (status == "Có hàng cận date")
                {
                    e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);
                    e.Appearance.ForeColor = Color.YellowGreen; // Đặt màu chữ
                }
            }
        }
    }
}