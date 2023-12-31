using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Qly_NhaHang.GUI_ADD;
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

namespace Qly_NhaHang.GUI_ADMIN
{
    public partial class frmSupplier : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmSupplier()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
            InitializeGridViewOptions();

        }
        private void InitializeGridViewOptions()
        {
            GridView gridView = gctSupplier.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvSupplier_FocusedRowChanged;
        }
        public void LoadFormSupplier()
        {
            var catalogData = dbContext.Suppliers
                             .Where(ct => ct.condition_Supplier == "Hợp tác")
                            .Select(ct => new SupplierModel
                            {
                                id_Supplier = ct.id_Supplier,
                                name_Supplier = ct.name_Supplier,
                                note_Supplier = ct.note_Supplier,
                                condition_Supplier = ct.condition_Supplier,
                               
                            }).ToList();
            gctSupplier.DataSource = catalogData;
        }

        private void btnLoadSupplier_Click(object sender, EventArgs e)
        {
            LoadFormSupplier();
        }

        private void gvSupplier_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateSupplierControls(e.FocusedRowHandle);
            }
        }
        private void UpdateSupplierControls(int focusedRowHandle)
        {
            SupplierModel selectedUnit = gvSupplier.GetRow(focusedRowHandle) as SupplierModel;
            if (selectedUnit != null)
            {
                txbIdSupplier.Text = selectedUnit.id_Supplier.ToString();
                txbNameSupplier.Text = selectedUnit.name_Supplier;
                txbNote.Text = selectedUnit.note_Supplier;

            }
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadFormSupplier();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbIdSupplier.Text, out int supplierId))
            {
                Supplier supplierToUpdate = dbContext.Suppliers.FirstOrDefault(ct => ct.id_Supplier == supplierId);

                if (supplierToUpdate != null)
                {
                    UpdateSupplierProperties(supplierToUpdate);

                    dbContext.Entry(supplierToUpdate).State = EntityState.Modified;
                    dbContext.SaveChanges();
                    LoadFormSupplier();
                    XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void UpdateSupplierProperties(Supplier supplier)
        {
            supplier.name_Supplier = txbNameSupplier.Text;
            supplier.note_Supplier = txbNote.Text;

        }

        private void btnPDFSupplier_Click(object sender, EventArgs e)
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

                for (int row = 0; row < gvSupplier.RowCount; row++)
                {
                    double x = 20;

                    if (row == 0)
                    {
                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gvSupplier.Columns)
                        {
                            gfx.DrawString(column.Caption, font, XBrushes.Black, x, y);
                            x += 100;
                        }
                        y += 20;
                        x = 20;
                    }

                    for (int col = 0; col < gvSupplier.Columns.Count; col++)
                    {
                        object cellValue = gvSupplier.GetRowCellValue(row, gvSupplier.Columns[col]);
                        gfx.DrawString(cellValue.ToString(), font, XBrushes.Black, x, y);
                        x += 100;
                    }
                    y += rowHeight;
                    if (y + rowHeight > page.Height - 20 && row < gvSupplier.RowCount - 1)
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

        private void btnCSVSupplier_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("CategoryData");
                    for (int col = 0; col < gvSupplier.Columns.Count; col++)
                    {
                        worksheet.Column(col + 1).Width = 15;
                    }
                    for (int i = 0; i < gvSupplier.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = gvSupplier.Columns[i].Caption;
                    }
                    for (int row = 0; row < gvSupplier.RowCount; row++)
                    {
                        worksheet.Row(row + 2).Height = 60;
                        for (int col = 0; col < gvSupplier.Columns.Count; col++)
                        {
                            object cellValue = gvSupplier.GetRowCellValue(row, gvSupplier.Columns[col]);
                            worksheet.Cell(row + 2, col + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                        }
                    }
                    workbook.SaveAs(filePath);
                }
                XtraMessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmAddSupplier addSupplierForm = new frmAddSupplier();
            DialogResult result = addSupplierForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadFormSupplier();
            }
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvSupplier.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                SupplierModel selectedSupplier = gvSupplier.GetRow(focusedRowHandle) as SupplierModel;
                if (selectedSupplier != null)
                {
                    if (int.TryParse(selectedSupplier.id_Supplier.ToString(), out int supplierId))
                    {
                        Supplier supplierToUpdate = dbContext.Suppliers.FirstOrDefault(ct => ct.id_Supplier == supplierId);

                        if (supplierToUpdate != null)
                        {
                            supplierToUpdate.condition_Supplier = "Ngừng hợp tác";
                            dbContext.Entry(supplierToUpdate).State = EntityState.Modified;
                            dbContext.SaveChanges();
                            LoadFormSupplier();
                            XtraMessageBox.Show("Nhà cung cấp ngừng hợp tác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}