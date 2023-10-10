using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
    }
}