using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Qly_NhaHang.Models;
using Qly_NhaHang.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmCategoryFood : DevExpress.XtraEditors.XtraForm
    {
        public frmCategoryFood()
        {
            InitializeComponent();
            InitializeGridViewOptions();
            LoadFormCategory(); 
        }
        QLNHThaiEntities db = new QLNHThaiEntities();

        private void InitializeGridViewOptions()
        {
            GridView gridView = gctCategory.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvCategory_FocusedRowChanged;

        }
        public void LoadFormCategory()
        {
            List<CategoryFood> categoryFoods = new List<CategoryFood>();
            categoryFoods = db.CategoryFoods.ToList();
            gctCategory.DataSource = categoryFoods;
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
            CategoryFood selectedCategory = gvCategory.GetRow(focusedRowHandle) as CategoryFood;
            if (selectedCategory != null)
            {
                txbIdCategory.Text = selectedCategory.id_Category.ToString();
                txbNameCategory.Text = selectedCategory.name_Category;
               
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmAddCategory addCategoryForm = new frmAddCategory();
            DialogResult result = addCategoryForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadFormCategory();             
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string newName = txbNameCategory.Text.Trim();

            // Kiểm tra xem tên danh mục mới có hợp lệ không (không rỗng)
            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Vui lòng nhập tên danh mục hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy dòng đang chọn trên lưới
            int focusedRowHandle = (gctCategory.MainView as GridView).FocusedRowHandle;
            CategoryFood selectedCategory = gvCategory.GetRow(focusedRowHandle) as CategoryFood;

            if (selectedCategory != null)
            {
                // Cập nhật tên danh mục trong đối tượng dòng được chọn
                selectedCategory.name_Category = newName;

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SaveChanges();

                // Cập nhật lưới hiển thị
                gvCategory.RefreshData();

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}