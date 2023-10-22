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

    public partial class frmRestoreCategory : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmRestoreCategory()
        {
            InitializeComponent();
            InitializeDbContext();
            dbContext = new QLNHThaiEntities();
            LoadFormCategory();
            InitializeGridViewOptions();
        }

        private void InitializeGridViewOptions()
        {
            GridView gridView = gctCategory.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvCategory_FocusedRowChanged;

        }
        private void InitializeDbContext()
        {
            dbContext = new QLNHThaiEntities();
        }
        public void LoadFormCategory()
        {
            var categoryData = dbContext.CategoryFoods
                             .Where(f => f.condition_Category == "Ngưng bán")
                            .Select(f => new CategoryView
                            {
                                id_Category = f.id_Category,
                                name_Category = f.name_Category,

                                condition_Category = f.condition_Category,


                            })
                            .ToList();
            gctCategory.DataSource = categoryData;
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvCategory.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                CategoryView selectedCategory = gvCategory.GetRow(focusedRowHandle) as CategoryView;
                if (selectedCategory != null)
                {
                    if (int.TryParse(selectedCategory.id_Category.ToString(), out int categoryId))
                    {
                        CategoryFood categoryToUpdate = dbContext.CategoryFoods.FirstOrDefault(ct => ct.id_Category == categoryId);

                        if (categoryToUpdate != null)
                        {
                            categoryToUpdate.condition_Category = "Được sử dụng";
                            dbContext.Entry(categoryToUpdate).State = EntityState.Modified;
                            dbContext.SaveChanges();
                            LoadFormCategory();
                            XtraMessageBox.Show("Được đưa vào kinh doanh !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void frmRestoreCategory_Load(object sender, EventArgs e)
        {
            LoadFormCategory();
        }

        private void btnLoadCategory_Click(object sender, EventArgs e)
        {
            LoadFormCategory();
        }

        private void gvCategory_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateCategoryControls(e.FocusedRowHandle);
            }
        }
        private void UpdateCategoryControls(int focusedRowHandle)
        {
            CategoryView selectedCategory = gvCategory.GetRow(focusedRowHandle) as CategoryView;
            if (selectedCategory != null)
            {
                txbIdCategory.Text = selectedCategory.id_Category.ToString();
                txbNameCategory.Text = selectedCategory.name_Category;
            }
        }

        private void btnPDFCategory_Click(object sender, EventArgs e)
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

                for (int row = 0; row < gvCategory.RowCount; row++)
                {
                    double x = 20;

                    if (row == 0)
                    {
                        // Vẽ tiêu đề cột cho trang đầu tiên
                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gvCategory.Columns)
                        {
                            gfx.DrawString(column.Caption, font, XBrushes.Black, x, y);
                            x += 100;
                        }
                        y += 20; // Điều chỉnh khoảng cách giữa tiêu đề cột và dữ liệu
                        x = 20;
                    }

                    for (int col = 0; col < gvCategory.Columns.Count; col++)
                    {
                        object cellValue = gvCategory.GetRowCellValue(row, gvCategory.Columns[col]);
                        gfx.DrawString(cellValue.ToString(), font, XBrushes.Black, x, y);
                        x += 100; // Điều chỉnh khoảng cách giữa các cột
                    }

                    y += rowHeight;

                    // Kiểm tra nếu không đủ không gian cho hàng tiếp theo, tạo trang mới
                    if (y + rowHeight > page.Height - 20 && row < gvCategory.RowCount - 1)
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

        private void btnCSVCategory_Click(object sender, EventArgs e)
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
                    for (int col = 0; col < gvCategory.Columns.Count; col++)
                    {
                        worksheet.Column(col + 1).Width = 15;
                    }

                    // Tiêu đề cột
                    for (int i = 0; i < gvCategory.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = gvCategory.Columns[i].Caption;
                    }

                    for (int row = 0; row < gvCategory.RowCount; row++)
                    {
                        // Đặt chiều cao hàng là 60
                        worksheet.Row(row + 2).Height = 60;

                        for (int col = 0; col < gvCategory.Columns.Count; col++)
                        {

                            object cellValue = gvCategory.GetRowCellValue(row, gvCategory.Columns[col]);
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