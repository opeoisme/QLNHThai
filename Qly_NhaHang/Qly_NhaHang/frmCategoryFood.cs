using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            { 
                GridView gridView = gctCategory.MainView as GridView;
                gridView.OptionsBehavior.ReadOnly = true;
            }
           
        }
        QLNHThaiEntities db = new QLNHThaiEntities();
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
    }
}