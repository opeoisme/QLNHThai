using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
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
    public partial class frmRestoreCatalog : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmRestoreCatalog()
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
                             .Where(ct => ct.condition_Catalog == "Ngừng sử dụng")
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

        private void frmRestoreCatalog_Load(object sender, EventArgs e)
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
            }
        }

        private void btnReloadCatalog_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvCatalog.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                CatalogView selectedCatalog = gvCatalog.GetRow(focusedRowHandle) as CatalogView;
                if (selectedCatalog != null)
                {
                    if (int.TryParse(selectedCatalog.id_Catalog.ToString(), out int catalogId))
                    {
                        CatalogIngredient catalogToUpdate = dbContext.CatalogIngredients.FirstOrDefault(ct => ct.id_Catalog == catalogId);

                        if (catalogToUpdate != null)
                        {
                            catalogToUpdate.condition_Catalog = "Sử dụng";
                            dbContext.Entry(catalogToUpdate).State = EntityState.Modified;
                            dbContext.SaveChanges();
                            LoadFormCatalog();
                            XtraMessageBox.Show("Được đưa vào kinh doanh !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnPDFCatalog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Danh sách Bàn";

                XFont font = new XFont("Arial", 9);
                int rowHeight = 60; // Điều chỉnh chiều cao của mỗi hàng
                double y = 20; // Vị trí bắt đầu của hàng đầu tiên

                // Đặt kích thước trang PDF
                PdfPage page = pdf.AddPage();
                page.Width = XUnit.FromInch(8.5); // Kích thước trang Letter (8.5 x 11 inch)
                page.Height = XUnit.FromInch(11);

                XGraphics gfx = XGraphics.FromPdfPage(page);

                for (int row = 0; row < gvCatalog.RowCount; row++)
                {
                    double x = 20;

                    if (row == 0)
                    {
                        // Vẽ tiêu đề cột cho trang đầu tiên
                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gvCatalog.Columns)
                        {
                            gfx.DrawString(column.Caption, font, XBrushes.Black, x, y);
                            x += 100;
                        }
                        y += 20; // Điều chỉnh khoảng cách giữa tiêu đề cột và dữ liệu
                        x = 20;
                    }

                    for (int col = 0; col < gvCatalog.Columns.Count; col++)
                    {
                        object cellValue = gvCatalog.GetRowCellValue(row, gvCatalog.Columns[col]);
                        gfx.DrawString(cellValue.ToString(), font, XBrushes.Black, x, y);
                        x += 100; // Điều chỉnh khoảng cách giữa các cột
                    }

                    y += rowHeight;

                    // Kiểm tra nếu không đủ không gian cho hàng tiếp theo, tạo trang mới
                    if (y + rowHeight > page.Height - 20 && row < gvCatalog.RowCount - 1)
                    {
                        page = pdf.AddPage();
                        page.Width = XUnit.FromInch(8.5);
                        page.Height = XUnit.FromInch(11);
                        gfx = XGraphics.FromPdfPage(page);
                        y = 20;
                    }
                }
                pdf.Save(filePath);
                XtraMessageBox.Show("Dữ liệu đã được xuất ra tệp PDF thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCSVCatalog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("CategoryData");

                    // Đặt chiều rộng cột cho tất cả các cột là 15
                    for (int col = 0; col < gvCatalog.Columns.Count; col++)
                    {
                        worksheet.Column(col + 1).Width = 15;
                    }

                    // Tiêu đề cột
                    for (int i = 0; i < gvCatalog.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = gvCatalog.Columns[i].Caption;
                    }

                    for (int row = 0; row < gvCatalog.RowCount; row++)
                    {
                        // Đặt chiều cao hàng là 60
                        worksheet.Row(row + 2).Height = 60;

                        for (int col = 0; col < gvCatalog.Columns.Count; col++)
                        {

                            object cellValue = gvCatalog.GetRowCellValue(row, gvCatalog.Columns[col]);
                            worksheet.Cell(row + 2, col + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;

                        }
                    }
                    workbook.SaveAs(filePath);
                }

                XtraMessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}