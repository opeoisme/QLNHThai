using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Qly_NhaHang.Models;
using Qly_NhaHang.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
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
        private QLNHThaiEntities dbContext;
      
        public frmCategoryFood()
        {
            InitializeComponent();
            InitializeGridViewOptions();
            dbContext = new QLNHThaiEntities();
            LoadFormCategory();
        }
       
        private void InitializeGridViewOptions()
        {
            GridView gridView = gctCategory.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvCategory_FocusedRowChanged;
        }

        public void LoadFormCategory()
        {
            var categoryData = dbContext.CategoryFoods
                             .Where(f => f.condition_Category == "Được sử dụng")
                            .Select(f => new CategoryView
                            {
                                id_Category = f.id_Category,
                                name_Category = f.name_Category,
                                condition_Category = f.condition_Category,
                            }).ToList();
            gctCategory.DataSource = categoryData;
        }

        private void UpdateCategoryProperties(CategoryFood category)
        {
            category.name_Category = txbNameCategory.Text;
            category.condition_Category = cbbConditionCategory.SelectedItem?.ToString();
           
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
                cbbConditionCategory.Text = selectedCategory.condition_Category.ToString();
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
            if (int.TryParse(txbIdCategory.Text, out int categoryId))
            {
                CategoryFood categoryToUpdate = dbContext.CategoryFoods.FirstOrDefault(ct => ct.id_Category == categoryId);

                if (categoryToUpdate != null)
                {
                    UpdateCategoryProperties(categoryToUpdate);

                    dbContext.Entry(categoryToUpdate).State = EntityState.Modified;
                    dbContext.SaveChanges();
                    LoadFormCategory();
                    XtraMessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void btnDeleteCategory_Click(object sender, EventArgs e)
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
                            categoryToUpdate.condition_Category = "Ngưng bán";

                            // Đánh dấu đối tượng là thay đổi
                            dbContext.Entry(categoryToUpdate).State = EntityState.Modified;

                            // Lưu thay đổi
                            dbContext.SaveChanges();

                            // Nạp lại dữ liệu sau khi cập nhật
                            LoadFormCategory();
                            XtraMessageBox.Show("Sản phẩm ngừng kinh doanh !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        private void frmCategoryFood_Load(object sender, EventArgs e)
        {
            LoadFormCategory();
        }

        private void frmCategoryFood_Shown(object sender, EventArgs e)
        {
            LoadFormCategory();
        }
    }
}