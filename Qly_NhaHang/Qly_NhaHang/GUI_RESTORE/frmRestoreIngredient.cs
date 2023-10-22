using DevExpress.XtraEditors;
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
    public partial class frmRestoreIngredient : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmRestoreIngredient()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
            LoadCategoryData();
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
                .Where(joinResult => joinResult.Ingredient.condition_Ingredient == "Ngừng sử dụng" || joinResult.Catalog.condition_Catalog == "Ngừng sử dụng")
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
                    price_Ingredient = (float)joinResult.Ingredient.price_Ingredient,
                })
                .ToList();
            gctIngredient.DataSource = ingredientData;
        }

        private void frmRestoreIngredient_Load(object sender, EventArgs e)
        {
            LoadIngredientData();
        }

        private void btnLoadIngredient_Click(object sender, EventArgs e)
        {
            LoadIngredientData();
        }



        private void UpdateIngredientControls(int focusedRowHandle)
        {
            IngredientView selectedIngredient = gvIngredient.GetRow(focusedRowHandle) as IngredientView;
            if (selectedIngredient != null)
            {
                txbIdIngredient.Text = selectedIngredient.id_Ingredient.ToString();
                txbNameIngredient.Text = selectedIngredient.name_Ingredient;
                txbCountIngre.Text = selectedIngredient.count_Ingredient.ToString();
                cbbUnitKid.Text = selectedIngredient.unitkid_Ingredient;
                txbCountKidIngre.Text = selectedIngredient.countkid_Ingredient.ToString();
                cbbUnitIngredient.Text = selectedIngredient.unit_Ingredient;
                txbStatusIngre.Text = selectedIngredient.status_Ingredient;
                txbPriceIngre.Text = String.Format("{0:0,0}", selectedIngredient.price_Ingredient);
                cbbCatalog.SelectedValue = selectedIngredient.id_Catalog;
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

        private void btnReloadIngredient_Click(object sender, EventArgs e)
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
                            ingredientToUpdate.condition_Ingredient = "Sử dụng";

                            // Đánh dấu đối tượng là thay đổi
                            dbContext.Entry(ingredientToUpdate).State = EntityState.Modified;

                            // Lưu thay đổi
                            dbContext.SaveChanges();

                            // Nạp lại dữ liệu sau khi cập nhật
                            LoadIngredientData();
                            XtraMessageBox.Show("Nguyên liệu được đưa vào sử dụng lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void gvIngredient_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateIngredientControls(e.FocusedRowHandle);
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
    }
}