﻿using DevExpress.Data.Utils;
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
    public partial class frmDiscount : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmDiscount()
        {
            InitializeComponent();
            InitializeGridViewOptions();
            dbContext = new QLNHThaiEntities(); // Khởi tạo dbContext ở đây
        }

        private void InitializeGridViewOptions()
        {
            GridView gridView = gctDiscount.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvDiscount_FocusedRowChanged;
        }

           
        public void LoadFormDiscount()
        {
            var discountData = dbContext.Discounts
                              .Where(dc => dc.condition_Discount == "Được áp dụng")
                             .Select(dc => new DiscountView
                             {
                                 id_Discount = dc.id_Discount,
                                 name_Discount = dc.name_Discount,
                                 percent_Discount = dc.percent_Discount,
                                 type_Discount = dc.type_Discount,  
                                 condition_Discount = dc.condition_Discount,    
                                 
                             }).ToList();
            gctDiscount.DataSource = discountData;
        }
        private void btnLoadDiscount_Click(object sender, EventArgs e)
        {
            LoadFormDiscount();
        }

        private void frmDiscount_Load(object sender, EventArgs e)
        {
            LoadFormDiscount();
        }

        private void btnUpdateDiscount_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbIdDiscount.Text, out int discountId))
            {
                Discount discountToUpdate = dbContext.Discounts.FirstOrDefault(i => i.id_Discount == discountId);

                if (discountToUpdate != null)
                {
                    // Kiểm tra và cập nhật các thuộc tính của Ingredient chỉ khi tất cả đều hợp lệ
                    if (UpdateDiscountProperties(discountToUpdate))
                    {
                        dbContext.Entry(discountToUpdate).State = EntityState.Modified;
                        dbContext.SaveChanges();
                        LoadFormDiscount();
                        XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                  
                }
            }
        }

        private bool UpdateDiscountProperties(Discount discount)
        {
            discount.name_Discount = txbNameDiscount.Text;
            discount.type_Discount = cbbTypeDiscount.SelectedItem?.ToString();
            if (int.TryParse(txbPercentDiscount.Text, out int percent) && percent >= 1 && percent <= 100)
            {
                discount.percent_Discount = percent;
                return true; // Trả về true nếu mọi thứ hợp lệ
            }
            else
            {
                XtraMessageBox.Show("Phần trăm giảm giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false; // Trả về false nếu có lỗi
            }
        }


        private void gvDiscount_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateDiscountControls(e.FocusedRowHandle);
            }
        }

        private void UpdateDiscountControls(int focusedRowHandle)
        {
            DiscountView selectedDiscount = gvDiscount.GetRow(focusedRowHandle) as DiscountView;
            if (selectedDiscount != null)
            {
                txbIdDiscount.Text = selectedDiscount.id_Discount.ToString();
                txbNameDiscount.Text = selectedDiscount.name_Discount;
              //  nmrPercentDiscount.Value = (decimal)selectedDiscount.percent_Discount;
                cbbTypeDiscount.Text = selectedDiscount.type_Discount;
                txbPercentDiscount.Text = selectedDiscount.percent_Discount.ToString();
            }
        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvDiscount.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                DiscountView selectedDiscount = gvDiscount.GetRow(focusedRowHandle) as DiscountView;
                if (selectedDiscount != null)
                {
                    if (int.TryParse(selectedDiscount.id_Discount.ToString(), out int discountId))
                    {
                        Discount discountToUpdate = dbContext.Discounts.FirstOrDefault(dc => dc.id_Discount == discountId);

                        if (discountToUpdate != null)
                        {
                            discountToUpdate.condition_Discount = "Hết chương trình";

                            // Đánh dấu đối tượng là thay đổi
                            dbContext.Entry(discountToUpdate).State = EntityState.Modified;

                            // Lưu thay đổi
                            dbContext.SaveChanges();

                            // Nạp lại dữ liệu sau khi cập nhật
                            LoadFormDiscount();
                            XtraMessageBox.Show("Chương trình ngừng hoạt động !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnReloadDiscount_Click(object sender, EventArgs e)
        {
            int[] selectedRows = gvDiscount.GetSelectedRows();

            foreach (int rowHandle in selectedRows)
            {
                Discount selectedDiscount = gvDiscount.GetRow(rowHandle) as Discount;
                if (selectedDiscount != null && selectedDiscount.condition_Discount != "Được áp dụng")
                {
                    if (int.TryParse(selectedDiscount.id_Discount.ToString(), out int discountId))
                    {
                        Discount discountToUpdate = dbContext.Discounts.FirstOrDefault(dc => dc.id_Discount == discountId);

                        if (discountToUpdate != null)
                        {
                            discountToUpdate.condition_Discount = "Được áp dụng";
                            dbContext.SaveChanges();
                            LoadFormDiscount();
                            XtraMessageBox.Show("Ưu đãi được đưa vào sử dụng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnAddDiscount_Click(object sender, EventArgs e)
        {
            frmAddDiscount addDiscountForm = new frmAddDiscount();
            DialogResult result = addDiscountForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadFormDiscount();
            }
        }

        private void btnPDFDiscount_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Danh sách Ưu đãi";

                XFont font = new XFont("Arial", 10);
                int rowHeight = 60; // Điều chỉnh chiều cao của mỗi hàng
                double y = 20; // Vị trí bắt đầu của hàng đầu tiên

                // Đặt kích thước trang PDF
                PdfPage page = pdf.AddPage();
                page.Width = XUnit.FromInch(8.5); // Kích thước trang Letter (8.5 x 11 inch)
                page.Height = XUnit.FromInch(11);

                XGraphics gfx = XGraphics.FromPdfPage(page);

                for (int row = 0; row < gvDiscount.RowCount; row++)
                {
                    double x = 20;

                    if (row == 0)
                    {
                        // Vẽ tiêu đề cột cho trang đầu tiên
                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gvDiscount.Columns)
                        {
                            gfx.DrawString(column.Caption, font, XBrushes.Black, x, y);
                            x += 100;
                        }
                        y += 20; // Điều chỉnh khoảng cách giữa tiêu đề cột và dữ liệu
                        x = 20;
                    }

                    for (int col = 0; col < gvDiscount.Columns.Count; col++)
                    {
                        object cellValue = gvDiscount.GetRowCellValue(row, gvDiscount.Columns[col]);
                        gfx.DrawString(cellValue.ToString(), font, XBrushes.Black, x, y);
                        x += 100; // Điều chỉnh khoảng cách giữa các cột
                    }

                    y += rowHeight;

                    // Kiểm tra nếu không đủ không gian cho hàng tiếp theo, tạo trang mới
                    if (y + rowHeight > page.Height - 20 && row < gvDiscount.RowCount - 1)
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

        private void btnCSVDiscount_Click(object sender, EventArgs e)
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
                    for (int col = 0; col < gvDiscount.Columns.Count; col++)
                    {
                        worksheet.Column(col + 1).Width = 15;
                    }

                    // Tiêu đề cột
                    for (int i = 0; i < gvDiscount.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = gvDiscount.Columns[i].Caption;
                    }

                    for (int row = 0; row < gvDiscount.RowCount; row++)
                    {
                        // Đặt chiều cao hàng là 60
                        worksheet.Row(row + 2).Height = 60;

                        for (int col = 0; col < gvDiscount.Columns.Count; col++)
                        {
                            if (gvDiscount.Columns[col].FieldName == "image_Food") // Xử lý cột hình ảnh
                            {
                                byte[] imageBytes = gvDiscount.GetRowCellValue(row, gvDiscount.Columns[col]) as byte[];
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
                                object cellValue = gvDiscount.GetRowCellValue(row, gvDiscount.Columns[col]);
                                worksheet.Cell(row + 2, col + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                            }
                        }
                    }

                    workbook.SaveAs(filePath);
                }

                XtraMessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}