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
    public partial class frmIngredient : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        private bool isImageChanged = false;
        string loggedInIdNV = frmLogin.LoggedInIdNV;
        
        /// </summary>
        public frmIngredient()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
            LoadCategoryData();
            UpdateIngredientStatus();
            InitializeGridViewOptions();
            


        }
        private void InitializeGridViewOptions()
        {
            GridView gridView = gctIngredient.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            // gridView.FocusedRowChanged += gridView1_FocusedRowChanged;

            gvIngredient.RowCellStyle += gvIngredient_RowCellStyle;
        }
        private void btnLoadIngredient_Click(object sender, EventArgs e)
        {
            LoadIngredientData();
            UpdateIngredientStatus();
        }

        private void frmIngredient_Load(object sender, EventArgs e)
        {
            LoadIngredientData();
            UpdateIngredientStatus();
        }
        private void LoadCategoryData()
        {
            var catalog = dbContext.CatalogIngredients.ToList();
            cbbCatalog.DataSource = catalog;
            cbbCatalog.DisplayMember = "name_Catalog";
            cbbCatalog.ValueMember = "id_Catalog";
        }

        public void LoadIngredientData()
        {
            var ingredientData = dbContext.Ingredients
                .Join(
                    dbContext.CatalogIngredients,
                    ingredient => ingredient.id_Catalog,
                    catalog => catalog.id_Catalog,
                    (ingredient, catalog) => new { Ingredient = ingredient, Catalog = catalog }
                )
                .Where(joinResult => joinResult.Ingredient.condition_Ingredient == "Sử dụng" && joinResult.Catalog.condition_Catalog == "Sử dụng")
                .Select(joinResult => new IngredientView
                {
                    id_Ingredient = joinResult.Ingredient.id_Ingredient,
                    name_Ingredient = joinResult.Ingredient.name_Ingredient,
                    unit_Ingredient = joinResult.Ingredient.unit_Ingredient,
                    count_Ingredient = (float)joinResult.Ingredient.count_Ingredient,
                    status_Ingredient = joinResult.Ingredient.status_Ingredient,
                    condition_Ingredient = joinResult.Ingredient.condition_Ingredient,
                    image_Ingredient = joinResult.Ingredient.image_Ingredient,
                    id_Catalog = (int)joinResult.Ingredient.id_Catalog,
                    countkid_Ingredient = (float)joinResult.Ingredient.countkid_Ingredient,
                    unitkid_Ingredient = joinResult.Ingredient.unitkid_Ingredient,
                })
                .ToList();
            gctIngredient.DataSource = ingredientData;
        }






        private void gvIngredient_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateIngredientControls(e.FocusedRowHandle);
            }
        }





        private void UpdateIngredientControls(int focusedRowHandle)
        {
            IngredientView selectedIngredient = gvIngredient.GetRow(focusedRowHandle) as IngredientView;
            if (selectedIngredient != null)
            {
                txbIdIngredient.Text = selectedIngredient.id_Ingredient.ToString();
                txbNameIngredient.Text = selectedIngredient.name_Ingredient;
                cbbCatalog.SelectedValue = selectedIngredient.id_Catalog;
                cbbConditionIngredient.Text = selectedIngredient.condition_Ingredient;
                nmrCountKid.Value = (decimal)selectedIngredient.countkid_Ingredient;
                nmrCountIngredient.Value = (decimal)selectedIngredient.count_Ingredient;
                cbbStatusIngredient.Text = selectedIngredient.status_Ingredient;
                cbbUnitKid.Text = selectedIngredient.unitkid_Ingredient;
                cbbUnitIngredient.Text = selectedIngredient.unit_Ingredient;
                if (selectedIngredient.image_Ingredient != null)
                {
                    using (MemoryStream ms = new MemoryStream(selectedIngredient.image_Ingredient))
                    {
                        imageIngredient.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    imageIngredient.Image = Properties.Resources.Food0;
                }
            }
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
                    imageIngredient.Image = new Bitmap(imageBitmap);

                    byte[] imageBytes = ConvertImageToByteArray(imageBitmap);
                    if (imageBytes != null)
                    {
                        UpdateIngredientImageInDatabase(imageBytes);
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

        private void UpdateIngredientImageInDatabase(byte[] imageBytes)
        {
            if (int.TryParse(txbIdIngredient.Text, out int selectedIngredientId))
            {
                Ingredient ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(ingredient => ingredient.id_Ingredient == selectedIngredientId);

                if (ingredientToUpdate != null)
                {
                    ingredientToUpdate.image_Ingredient = imageBytes;
                    dbContext.Entry(ingredientToUpdate).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
            }
        }

        private void UpdateIngredientProperties(Ingredient ingredient)
        {
            ingredient.name_Ingredient = txbNameIngredient.Text;
            ingredient.id_Catalog = Convert.ToInt32(cbbCatalog.SelectedValue);
            ingredient.condition_Ingredient = cbbConditionIngredient.SelectedItem?.ToString();
            ingredient.count_Ingredient = (float)nmrCountIngredient.Value;
            ingredient.countkid_Ingredient = (float)nmrCountKid.Value;
            ingredient.status_Ingredient = cbbStatusIngredient.SelectedItem?.ToString();
            ingredient.unitkid_Ingredient = cbbUnitKid.SelectedItem?.ToString();
            ingredient.unit_Ingredient = cbbUnitIngredient.SelectedItem?.ToString();


        }

        private void UpdateIngredientImage(Ingredient ingredientToUpdate)
        {
            byte[] imageBytes = ConvertImageToByteArray(imageIngredient.Image);
            if (imageBytes != null)
            {
                ingredientToUpdate.image_Ingredient = imageBytes;
                dbContext.SaveChanges();
            }
        }

        private void imageIngredient_Click(object sender, EventArgs e)
        {
            SelectAndSaveImage();
            isImageChanged = true;
        }

        private void btnUpdateIngredient_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbIdIngredient.Text, out int ingredientId))
            {
                Ingredient ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(i => i.id_Ingredient == ingredientId);

                if (ingredientToUpdate != null)
                {
                    UpdateIngredientProperties(ingredientToUpdate);

                    dbContext.Entry(ingredientToUpdate).State = EntityState.Modified;

                    if (isImageChanged && imageIngredient.Image != null)
                    {
                        UpdateIngredientImage(ingredientToUpdate);
                    }
                    dbContext.SaveChanges();
                    LoadIngredientData();
                    XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            isImageChanged = false;
        }

        private void btnDeleteIngredient_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvIngredient.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                IngredientView selectedIngredient = gvIngredient.GetRow(focusedRowHandle) as IngredientView;
                if (selectedIngredient != null)
                {
                    if (int.TryParse(selectedIngredient.id_Ingredient.ToString(), out int ingredientId))
                    {
                        Ingredient ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(i => i.id_Ingredient == ingredientId);

                        if (ingredientToUpdate != null)
                        {
                            ingredientToUpdate.condition_Ingredient = "Ngừng sử dụng";

                            // Đánh dấu đối tượng là thay đổi
                            dbContext.Entry(ingredientToUpdate).State = EntityState.Modified;

                            // Lưu thay đổi
                            dbContext.SaveChanges();

                            // Nạp lại dữ liệu sau khi cập nhật
                            LoadIngredientData();
                            XtraMessageBox.Show("Nguyên liệu không được sử dụng nữa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btnCSVIngredient_Click(object sender, EventArgs e)
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
                    for (int col = 0; col < gvIngredient.Columns.Count; col++)
                    {
                        worksheet.Column(col + 1).Width = 15;
                    }
                    // Tiêu đề cột
                    for (int i = 0; i < gvIngredient.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = gvIngredient.Columns[i].Caption;
                    }
                    for (int row = 0; row < gvIngredient.RowCount; row++)
                    {
                        // Đặt chiều cao hàng là 60
                        worksheet.Row(row + 2).Height = 60;

                        for (int col = 0; col < gvIngredient.Columns.Count; col++)
                        {
                            if (gvIngredient.Columns[col].FieldName == "image_Ingredient") // Xử lý cột hình ảnh
                            {
                                byte[] imageBytes = gvIngredient.GetRowCellValue(row, gvIngredient.Columns[col]) as byte[];
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
                                object cellValue = gvIngredient.GetRowCellValue(row, gvIngredient.Columns[col]);
                                worksheet.Cell(row + 2, col + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                            }
                        }
                    }
                    workbook.SaveAs(filePath);
                }
                XtraMessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPDFIngredient_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                PdfDocument pdf = new PdfDocument();
                pdf.Info.Title = "Danh sách nhân viên";

                XFont font = new XFont("Arial", 7);
                int rowHeight = 60; // Điều chỉnh chiều cao của mỗi hàng
                double y = 20; // Vị trí bắt đầu của hàng đầu tiên

                PdfPage page = null; // Khởi tạo trang
                XGraphics gfx = null;

                for (int row = 0; row < gvIngredient.RowCount; row++)
                {
                    double x = 20;

                    if (page == null)
                    {
                        // Tạo trang đầu tiên
                        page = pdf.AddPage();
                        page.Width = XUnit.FromInch(9); // Kích thước trang Letter (8.5 x 11 inch)
                        page.Height = XUnit.FromInch(11);
                        gfx = XGraphics.FromPdfPage(page);

                        // Vẽ tiêu đề cột cho trang đầu tiên
                        foreach (DevExpress.XtraGrid.Columns.GridColumn column in gvIngredient.Columns)
                        {
                            gfx.DrawString(column.Caption, font, XBrushes.Black, x, y);
                            x += 60; // Điều chỉnh khoảng cách giữa các cột
                        }
                        y += 20; // Điều chỉnh khoảng cách giữa tiêu đề cột và dữ liệu
                        x = 20;
                    }

                    for (int col = 0; col < gvIngredient.Columns.Count; col++)
                    {
                        object cellValue = gvIngredient.GetRowCellValue(row, gvIngredient.Columns[col]);
                        if (gvIngredient.Columns[col].FieldName == "image_Ingredient")
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

                        x += 60; // Điều chỉnh khoảng cách giữa các cột
                    }

                    y += rowHeight;

                    // Kiểm tra nếu không đủ không gian cho hàng tiếp theo, tạo trang mới
                    if (y + rowHeight > page.Height - 20 && row < gvIngredient.RowCount - 1)
                    {
                        page = null; // Đánh dấu để tạo trang mới trong vòng lặp tiếp theo
                        y = 20;
                    }
                }

                pdf.Save(filePath);

                XtraMessageBox.Show("Dữ liệu đã được xuất ra tệp PDF thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImportIngredient_Click(object sender, EventArgs e)
        {
            string id_NV = loggedInIdNV;
            DateTime currentTime = DateTime.Now;
            DialogResult result = XtraMessageBox.Show("Bạn có muốn nhập hàng không?", "Xác nhận nhập hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var context = new QLNHThaiEntities())
                {
                    Import newImport = new Import 
                    {
                        date_Import = currentTime,
                        id_NV = id_NV,
                        type_Import = "Nhập hàng",                               
                    };
                    context.Imports.Add(newImport); 
                    context.SaveChanges();
                    int idImport = newImport.id_Import;
                    frmImport f = new frmImport();
                    f.SetIdImport(idImport);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                return;
            }
        }


















        private void UpdateIngredientStatus()
        {
            DateTime currentDate = DateTime.Today.AddDays(1); // Ngày hiện tại + 1 ngày

            // Lấy danh sách các id_Ingredient có ít nhất một Import_Info có date_Expiry hơn ngày hiện tại + 1 ngày và count_Ingredient > 0
            var candate = dbContext.ImportInfoes
                .Where(info => info.date_Expiry == currentDate && info.count_Ingredient > 0)
                .Select(info => info.id_Ingredient)
                .Distinct()
                .ToList();

            // Lấy danh sách các id_Ingredient có ít nhất một Import_Info có date_Expiry hơn ngày hiện tại + 2 ngày và count_Ingredient > 0
            var ondinh = dbContext.ImportInfoes
                .Where(info => info.date_Expiry >= currentDate && info.count_Ingredient == 0)
                .Select(info => info.id_Ingredient)
                .Distinct()
                .ToList();

            // Lấy danh sách các id_Ingredient có ít nhất một Import_Info có date_Expiry bằng ngày hiện tại và count_Ingredient > 0
            var hetdate = dbContext.ImportInfoes
                .Where(info => info.date_Expiry < currentDate && info.count_Ingredient > 0)
                .Select(info => info.id_Ingredient)
                .Distinct()
                .ToList();

            // Lấy danh sách các id_Ingredient có cả "Có hàng sắp hết hạn" và "Có hàng hết hạn"
            var hethancandate = candate
                .Where(id => hetdate.Contains(id))
                .ToList();


            foreach (var ingredientId in ondinh)
            {
                // Tìm nguyên liệu tương ứng trong bảng Ingredients
                var ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(ingredient => ingredient.id_Ingredient == ingredientId);

                if (ingredientToUpdate != null)
                {
                    // Ưu tiên trạng thái "Ổn định"
                    ingredientToUpdate.status_Ingredient = "Ổn định";
                }
            }

            foreach (var ingredientId in candate)
            {
                // Tìm nguyên liệu tương ứng trong bảng Ingredients
                var ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(ingredient => ingredient.id_Ingredient == ingredientId);

                if (ingredientToUpdate != null)
                {
                    // Ưu tiên trạng thái "Có hàng sắp hết hạn"
                    ingredientToUpdate.status_Ingredient = "Có hàng cận date";
                }
            }

            foreach (var ingredientId in hetdate)
            {
                // Tìm nguyên liệu tương ứng trong bảng Ingredients
                var ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(ingredient => ingredient.id_Ingredient == ingredientId);

                if (ingredientToUpdate != null)
                {
                    // Ưu tiên trạng thái "Có hàng hết hạn"
                    ingredientToUpdate.status_Ingredient = "Có hàng hết date";
                }
            }

            foreach (var ingredientId in hethancandate)
            {
                // Tìm nguyên liệu tương ứng trong bảng Ingredients
                var ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(ingredient => ingredient.id_Ingredient == ingredientId);

                if (ingredientToUpdate != null)
                {
                    // Đặt trạng thái "Có hàng cận date và đã hết hạn"
                    ingredientToUpdate.status_Ingredient = "Có hàng cận date và hết hạn";
                }
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            dbContext.SaveChanges();
        }

        private void gvIngredient_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName == "status_Ingredient" && e.CellValue != null)
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
























        //private void UpdateIngredientStatus()
        //{
        //    DateTime currentDate1 = DateTime.Today.AddDays(1); // Ngày hiện tại + 1 ngày
        //  // DateTime currentDate = DateTime.Today;

        //    var candate = dbContext.ImportInfoes
        //        .Where(info => info.date_Expiry == currentDate1 && info.count_Ingredient > 0)
        //        .ToList();

        //    var ondinh = dbContext.ImportInfoes
        //        .Where(info => info.date_Expiry > currentDate1 )
        //        .ToList();

        //    var hethan = dbContext.ImportInfoes
        //        .Where(info => info.date_Expiry < currentDate1 && info.count_Ingredient > 0)
        //        .ToList();

        //    var candatehethan = dbContext.ImportInfoes
        //        .Where(info => info.date_Expiry < currentDate1 && info.date_Expiry == currentDate1 && info.count_Ingredient > 0)
        //        .ToList();


        //    foreach (var importInfo in ondinh)
        //    {
        //        // Tìm nguyên liệu tương ứng trong bảng Ingredients
        //        var ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(ingredient => ingredient.id_Ingredient == importInfo.id_Ingredient);

        //        if (ingredientToUpdate != null)
        //        {
        //            // Cập nhật trạng thái của nguyên liệu
        //            ingredientToUpdate.status_Ingredient = "Ổn định";
        //        }
        //        dbContext.SaveChanges();
        //    }
        //    foreach (var importInfo in candate)
        //    {
        //        // Tìm nguyên liệu tương ứng trong bảng Ingredients
        //        var ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(ingredient => ingredient.id_Ingredient == importInfo.id_Ingredient);

        //        if (ingredientToUpdate != null)
        //        {
        //            // Cập nhật trạng thái của nguyên liệu
        //            ingredientToUpdate.status_Ingredient = "Có hàng sắp hết hạn";
        //        }
        //        dbContext.SaveChanges();
        //    }
        //    foreach (var importInfo in hethan)
        //    {
        //        // Tìm nguyên liệu tương ứng trong bảng Ingredients
        //        var ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(ingredient => ingredient.id_Ingredient == importInfo.id_Ingredient);

        //        if (ingredientToUpdate != null)
        //        {
        //            // Cập nhật trạng thái của nguyên liệu
        //            ingredientToUpdate.status_Ingredient = "Hàng hết hạn";
        //        }
        //        dbContext.SaveChanges();
        //    }
        //    foreach (var importInfo in candatehethan)
        //    {
        //        // Tìm nguyên liệu tương ứng trong bảng Ingredients
        //        var ingredientToUpdate = dbContext.Ingredients.FirstOrDefault(ingredient => ingredient.id_Ingredient == importInfo.id_Ingredient);

        //        if (ingredientToUpdate != null)
        //        {
        //            // Cập nhật trạng thái của nguyên liệu
        //            ingredientToUpdate.status_Ingredient = "Hàng cận date và hết hạn";
        //        }
        //        dbContext.SaveChanges();
        //    }

        //    dbContext.SaveChanges();
        //}

    }
}