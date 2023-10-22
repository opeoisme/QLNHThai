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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class FrmRestoreTable : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public FrmRestoreTable()
        {
            InitializeComponent();
            InitializeGridViewOptions();
            dbContext = new QLNHThaiEntities();
            LoadFormTable();
        }
        public void LoadFormTable()
        {
            var tableData = dbContext.Tablees
                              .Where(tb => tb.condition_Table == "Ngưng sử dụng")
                             .Select(tb => new TableView
                             {
                                 id_Table = tb.id_Table,
                                 name_Table = tb.name_Table,
                                 status_Table = tb.status_Table,
                                 seats_Table = (int)tb.seats_Table,
                                 condition_Table = tb.condition_Table,
                             }).ToList();
            gctTable.DataSource = tableData;
        }

        private void InitializeGridViewOptions()
        {
            GridView gridView = gctTable.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvTable_FocusedRowChanged;


        }

        private void gvTable_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateTableControls(e.FocusedRowHandle);
            }
        }
        private void UpdateTableControls(int focusedRowHandle)
        {
            TableView selectedTable = gvTable.GetRow(focusedRowHandle) as TableView;
            if (selectedTable != null)
            {
                txbIdTable.Text = selectedTable.id_Table.ToString();
                txbNameTable.Text = selectedTable.name_Table;
                txbSeatTable.Text = selectedTable.seats_Table.ToString();
                txbStatusTable.Text = selectedTable.status_Table;

            }
        }

        private void btnReloadTable_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvTable.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                TableView selectedTable = gvTable.GetRow(focusedRowHandle) as TableView;
                if (selectedTable != null)
                {
                    if (int.TryParse(selectedTable.id_Table.ToString(), out int tableId))
                    {
                        Tablee tableToUpdate = dbContext.Tablees.FirstOrDefault(tb => tb.id_Table == tableId);

                        if (tableToUpdate != null)
                        {
                            tableToUpdate.condition_Table = "Được sử dụng";

                            // Đánh dấu đối tượng là thay đổi
                            dbContext.Entry(tableToUpdate).State = EntityState.Modified;

                            // Lưu thay đổi
                            dbContext.SaveChanges();

                            // Nạp lại dữ liệu sau khi cập nhật
                            LoadFormTable();
                            XtraMessageBox.Show("Bàn được đưa vào sử dụng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            LoadFormTable();
        }

        private void btnPDFTable_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("TableData");

                    // Đặt chiều rộng cột cho tất cả các cột là 15
                    for (int col = 0; col < gvTable.Columns.Count; col++)
                    {
                        worksheet.Column(col + 1).Width = 15;
                    }

                    // Tiêu đề cột
                    for (int i = 0; i < gvTable.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = gvTable.Columns[i].Caption;
                    }

                    for (int row = 0; row < gvTable.RowCount; row++)
                    {
                        // Đặt chiều cao hàng là 60
                        worksheet.Row(row + 2).Height = 60;

                        for (int col = 0; col < gvTable.Columns.Count; col++)
                        {
                            if (gvTable.Columns[col].FieldName == "image_Food") // Xử lý cột hình ảnh
                            {
                                byte[] imageBytes = gvTable.GetRowCellValue(row, gvTable.Columns[col]) as byte[];
                                if (imageBytes != null)
                                {
                                    using (MemoryStream ms = new MemoryStream(imageBytes))
                                    {
                                        var image = worksheet.AddPicture(ms).MoveTo(worksheet.Cell(row + 2, col + 1));
                                        image.Width = 80;
                                        image.Height = 80;
                                    }
                                }
                            }
                            else
                            {
                                object cellValue = gvTable.GetRowCellValue(row, gvTable.Columns[col]);
                                worksheet.Cell(row + 2, col + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                            }
                        }
                    }

                    workbook.SaveAs(filePath);
                }

                XtraMessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCSVTable_Click(object sender, EventArgs e)
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

                for (int row = 0; row < gvTable.RowCount; row++)
                {
                    double x = 20;

                    if (row == 0)
                    {
                        // Vẽ tiêu đề cột cho trang đầu tiên
                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gvTable.Columns)
                        {
                            gfx.DrawString(column.Caption, font, XBrushes.Black, x, y);
                            x += 100;
                        }
                        y += 20; // Điều chỉnh khoảng cách giữa tiêu đề cột và dữ liệu
                        x = 20;
                    }

                    for (int col = 0; col < gvTable.Columns.Count; col++)
                    {
                        object cellValue = gvTable.GetRowCellValue(row, gvTable.Columns[col]);
                        gfx.DrawString(cellValue.ToString(), font, XBrushes.Black, x, y);
                        x += 100; // Điều chỉnh khoảng cách giữa các cột
                    }

                    y += rowHeight;

                    // Kiểm tra nếu không đủ không gian cho hàng tiếp theo, tạo trang mới
                    if (y + rowHeight > page.Height - 20 && row < gvTable.RowCount - 1)
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
    }
}