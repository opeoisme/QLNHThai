using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Qly_NhaHang.Models;
using Qly_NhaHang.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        private bool isImageChanged = false;
        string loggedInIdNV = frmLogin.LoggedInIdNV;

        public frmNhanVien()
        {
            InitializeComponent();
            InitializeGridViewOptions();
            dbContext = new QLNHThaiEntities();
        }

        public void LoadFormNV()
        {
            var nhanvienData = dbContext.NhanViens
                             .Where(nv => nv.condition_NV == "Làm việc")
                            .Select(nv => new NhanVienView
                            {
                                id_NV = nv.id_NV,
                                name_NV = nv.name_NV,
                                sex_NV = nv.sex_NV,
                                address_NV = nv.address_NV,
                                CCCD_NV = nv.CCCD_NV,
                                phone_NV = nv.phone_NV,
                                image_NV = nv.image_NV,
                                type_NV = nv.type_NV,
                                condition_NV = nv.condition_NV,
                                pass_NV = nv.pass_NV,
                            }).ToList();
            gctNV.DataSource = nhanvienData;
        }

        private void InitializeGridViewOptions()
        {
            GridView gridView = gctNV.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvNV_FocusedRowChanged;
        }

        private void imgNV_Click(object sender, EventArgs e)
        {
            SelectAndSaveImage();
            isImageChanged = true;
        }

        private void SelectAndSaveImage()
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;";
            DialogResult choose = open.ShowDialog();

            if (choose == DialogResult.OK)
            {
                string imagePath = open.FileName;

                using (Bitmap imageBitmap = new Bitmap(Image.FromFile(imagePath)))
                {
                    imgNV.Image = new Bitmap(imageBitmap);

                    byte[] imageBytes = ConvertImageToByteArray(imageBitmap);
                    if (imageBytes != null)
                    {
                        UpdateNhanVIenImageInDatabase(imageBytes);
                    }
                }
            }
        }

        private byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                try
                {
                    image.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi khi chuyển đổi hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
        }

        private void UpdateNhanVIenImageInDatabase(byte[] imageBytes)
        {
            string selectedNVId = txbIdNV.Text; // Lấy giá trị id_NV kiểu string từ TextBox

            NhanVien nhanvienToUpdate = dbContext.NhanViens.FirstOrDefault(nhanvien => nhanvien.id_NV == selectedNVId);

            if (nhanvienToUpdate != null)
            {
                nhanvienToUpdate.image_NV = imageBytes;
                // Không cần thay đổi EntityState vì nó đã tự động được cập nhật trong context
                dbContext.SaveChanges();
            }
        }

        private void gvNV_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateNhanVienControls(e.FocusedRowHandle);
            }
        }

        private void UpdateNhanVienControls(int focusedRowHandle)
        {
            NhanVienView selectedNhanvien = gvNV.GetRow(focusedRowHandle) as NhanVienView;
            if (selectedNhanvien != null)
            {
                txbIdNV.Text = selectedNhanvien.id_NV;
                txbNameNV.Text = selectedNhanvien.name_NV;
                cbbSexNV.SelectedItem = selectedNhanvien.sex_NV;
                txbAddressNV.Text = selectedNhanvien.address_NV;
                txbCCCDNV.Text = selectedNhanvien.CCCD_NV;
                txbPhoneNV.Text = selectedNhanvien.phone_NV;

                cbbTypeNV.SelectedItem = selectedNhanvien.type_NV;

                if (selectedNhanvien.image_NV != null)
                {
                    using (MemoryStream ms = new MemoryStream(selectedNhanvien.image_NV))
                    {
                        imgNV.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    imgNV.Image = Properties.Resources.Food0;
                }
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            LoadFormNV();
        }

        private void btnLoadNV_Click(object sender, EventArgs e)
        {
            LoadFormNV();
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            string nhanvienId = txbIdNV.Text;

            if (!string.IsNullOrEmpty(nhanvienId))
            {
                NhanVien nhanvienToUpdate = dbContext.NhanViens.FirstOrDefault(nv => nv.id_NV == nhanvienId);

                if (nhanvienToUpdate != null)
                {
                    UpdateNhanvienProperties(nhanvienToUpdate);

                    if (isImageChanged && imgNV.Image != null)
                    {
                        UpdateNhanvienImage(nhanvienToUpdate);
                    }

                    dbContext.SaveChanges();
                    LoadFormNV();

                    // Hiển thị thông báo thành công
                    XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            // Reset isImageChanged sau khi đã sử dụng
            isImageChanged = false;
        }


        private void UpdateNhanvienProperties(NhanVien nhanvien)
        {
            nhanvien.name_NV = txbNameNV.Text;
            nhanvien.sex_NV = cbbSexNV.SelectedItem?.ToString();
            nhanvien.phone_NV = txbPhoneNV.Text;
            nhanvien.address_NV = txbAddressNV.Text;
            nhanvien.CCCD_NV = txbCCCDNV.Text;
            nhanvien.type_NV = cbbTypeNV.SelectedItem?.ToString();

        }
        private void UpdateNhanvienImage(NhanVien nhanvienToUpdate)
        {
            byte[] imageBytes = ConvertImageToByteArray(imgNV.Image); // Fix: imageNV to imgNV
            if (imageBytes != null)
            {
                nhanvienToUpdate.image_NV = imageBytes;
                dbContext.SaveChanges();
            }
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvNV.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                NhanVienView selectedNhanvien = gvNV.GetRow(focusedRowHandle) as NhanVienView;
                if (selectedNhanvien != null)
                {
                    string nhanvienId = selectedNhanvien.id_NV;

                    // Loại bỏ khoảng trắng thừa trước khi so sánh
                    string trimmedNhanvienId = nhanvienId.Trim();
                    string trimmedLoggedInIdNV = loggedInIdNV.Trim();

                    // Kiểm tra nếu id_NV trùng với id_NV đã đăng nhập thành công
                    if (string.Equals(trimmedNhanvienId, trimmedLoggedInIdNV, StringComparison.OrdinalIgnoreCase))
                    {
                        XtraMessageBox.Show("Không thể xóa nhân viên này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    NhanVien nhanvienToDelete = dbContext.NhanViens.FirstOrDefault(nv => nv.id_NV == nhanvienId);

                    if (nhanvienToDelete != null)
                    {
                        nhanvienToDelete.condition_NV = "Nghỉ việc";

                        // Đánh dấu đối tượng là thay đổi
                        dbContext.Entry(nhanvienToDelete).State = EntityState.Modified;

                        dbContext.SaveChanges();

                        // Load lại danh sách sau khi cập nhật
                        LoadFormNV();

                        // Mờ trường dữ liệu tương ứng trên GridView
                        gvNV.SetRowCellValue(focusedRowHandle, gvNV.Columns["condition_NV"], "Nghỉ việc");
                        XtraMessageBox.Show("Nhân viên không còn làm việc !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        private void btnCSVNV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                using (var workbook = new ClosedXML.Excel.XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("FoodData");

                    // Đặt chiều rộng cột cho tất cả các cột là 15
                    for (int col = 0; col < gvNV.Columns.Count; col++)
                    {
                        worksheet.Column(col + 1).Width = 15;
                    }

                    // Tiêu đề cột
                    for (int i = 0; i < gvNV.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = gvNV.Columns[i].Caption;
                    }

                    for (int row = 0; row < gvNV.RowCount; row++)
                    {
                        // Đặt chiều cao hàng là 60
                        worksheet.Row(row + 2).Height = 60;

                        for (int col = 0; col < gvNV.Columns.Count; col++)
                        {
                            if (gvNV.Columns[col].FieldName == "image_NV") // Xử lý cột hình ảnh
                            {
                                byte[] imageBytes = gvNV.GetRowCellValue(row, gvNV.Columns[col]) as byte[];
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
                                object cellValue = gvNV.GetRowCellValue(row, gvNV.Columns[col]);
                                worksheet.Cell(row + 2, col + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                            }
                        }
                    }
                    workbook.SaveAs(filePath);
                }

                XtraMessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            frmAddNhanVien addNVForm = new frmAddNhanVien();
            DialogResult result = addNVForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadFormNV();
            }
        }

        private void btnPDFNV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Danh sách nhân viên";

                XFont font = new XFont("Arial", 5);
                int rowHeight = 60; // Điều chỉnh chiều cao của mỗi hàng
                double y = 20; // Vị trí bắt đầu của hàng đầu tiên

                // Đặt kích thước trang PDF
                PdfPage page = pdf.AddPage();
                page.Width = XUnit.FromInch(11); // Kích thước trang Letter (8.5 x 11 inch)
                page.Height = XUnit.FromInch(8.5);

                XGraphics gfx = XGraphics.FromPdfPage(page);

                for (int row = 0; row < gvNV.RowCount; row++)
                {
                    double x = 20;

                    if (row == 0)
                    {
                        // Vẽ tiêu đề cột cho trang đầu tiên
                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gvNV.Columns)
                        {
                            gfx.DrawString(column.Caption, font, XBrushes.Black, x, y);
                            x += 80; // Điều chỉnh khoảng cách giữa các cột
                        }
                        y += 20; // Điều chỉnh khoảng cách giữa tiêu đề cột và dữ liệu
                        x = 20;
                    }

                    for (int col = 0; col < gvNV.Columns.Count; col++)
                    {
                        object cellValue = gvNV.GetRowCellValue(row, gvNV.Columns[col]);
                        if (gvNV.Columns[col].FieldName == "image_NV")
                        {
                            byte[] imageBytes = cellValue as byte[];
                            if (imageBytes != null)
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    System.Drawing.Image image = System.Drawing.Image.FromStream(ms);

                                    // Điều chỉnh kích thước của hình ảnh để tối ưu hóa trên trang
                                    double imageWidth = 50;
                                    double imageHeight = 30;
                                    XImage xImage = XImage.FromStream(ms);
                                    gfx.DrawImage(xImage, x, y, imageWidth, imageHeight);
                                }
                            }
                            else
                            {
                                gfx.DrawString("", font, XBrushes.Black, x, y);
                            }
                        }
                        else
                        {
                            gfx.DrawString(cellValue != null ? cellValue.ToString() : string.Empty, font, XBrushes.Black, x, y);
                        }

                        x += 80; // Điều chỉnh khoảng cách giữa các cột

                    }

                    y += rowHeight;

                    // Kiểm tra nếu không đủ không gian cho hàng tiếp theo, tạo trang mới
                    if (y + rowHeight > page.Height - 20 && row < gvNV.RowCount - 1)
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
