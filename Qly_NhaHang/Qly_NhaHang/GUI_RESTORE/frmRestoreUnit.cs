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

namespace Qly_NhaHang.GUI_RESTORE
{
    public partial class frmRestoreUnit : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmRestoreUnit()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
            InitializeGridViewOptions();
        }
        private void InitializeGridViewOptions()
        {
            GridView gridView = gctUnit.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvUnit_FocusedRowChanged;
        }
        public void LoadFormUnit()
        {
            var catalogData = dbContext.Units
                             .Where(ct => ct.condition_Unit == "Ngừng sử dụng")
                            .Select(ct => new UnitModel
                            {
                                id_Unit = ct.id_Unit,
                                name_Unit = ct.name_Unit,
                                condition_Unit = ct.condition_Unit,
                            }).ToList();
            gctUnit.DataSource = catalogData;
        }

        private void frmRestoreUnit_Load(object sender, EventArgs e)
        {
            LoadFormUnit();
        }

        private void gvUnit_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateUnitControls(e.FocusedRowHandle);
            }
        }
        private void UpdateUnitControls(int focusedRowHandle)
        {
            UnitModel selectedUnit = gvUnit.GetRow(focusedRowHandle) as UnitModel;
            if (selectedUnit != null)
            {
                txbIdUnit.Text = selectedUnit.id_Unit.ToString();
                txbNameUnit.Text = selectedUnit.name_Unit;

            }
        }

      

        private void btnReloadUnit_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvUnit.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                UnitModel selectedUnit = gvUnit.GetRow(focusedRowHandle) as UnitModel;
                if (selectedUnit != null)
                {
                    if (int.TryParse(selectedUnit.id_Unit.ToString(), out int unitId))
                    {
                        Unit unitToUpdate = dbContext.Units.FirstOrDefault(ct => ct.id_Unit == unitId);

                        if (unitToUpdate != null)
                        {
                            unitToUpdate.condition_Unit = "Sử dụng";
                            dbContext.Entry(unitToUpdate).State = EntityState.Modified;
                            dbContext.SaveChanges();
                            LoadFormUnit();
                            XtraMessageBox.Show("Đơn vị được sử dụng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnLoadUnit_Click(object sender, EventArgs e)
        {
            LoadFormUnit();

        }

        private void btnPDFUnit_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Danh sách Bàn";
                XFont font = new XFont("Arial", 9);
                int rowHeight = 60;
                double y = 20;
                PdfPage page = pdf.AddPage();
                page.Width = XUnit.FromInch(8.5);
                page.Height = XUnit.FromInch(11);
                XGraphics gfx = XGraphics.FromPdfPage(page);

                for (int row = 0; row < gvUnit.RowCount; row++)
                {
                    double x = 20;

                    if (row == 0)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gvUnit.Columns)
                        {
                            gfx.DrawString(column.Caption, font, XBrushes.Black, x, y);
                            x += 100;
                        }
                        y += 20;
                        x = 20;
                    }

                    for (int col = 0; col < gvUnit.Columns.Count; col++)
                    {
                        object cellValue = gvUnit.GetRowCellValue(row, gvUnit.Columns[col]);
                        gfx.DrawString(cellValue.ToString(), font, XBrushes.Black, x, y);
                        x += 100;
                    }
                    y += rowHeight;
                    if (y + rowHeight > page.Height - 20 && row < gvUnit.RowCount - 1)
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

        private void btnCSVUnit_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("CategoryData");
                    for (int col = 0; col < gvUnit.Columns.Count; col++)
                    {
                        worksheet.Column(col + 1).Width = 15;
                    }
                    for (int i = 0; i < gvUnit.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = gvUnit.Columns[i].Caption;
                    }
                    for (int row = 0; row < gvUnit.RowCount; row++)
                    {
                        worksheet.Row(row + 2).Height = 60;
                        for (int col = 0; col < gvUnit.Columns.Count; col++)
                        {
                            object cellValue = gvUnit.GetRowCellValue(row, gvUnit.Columns[col]);
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