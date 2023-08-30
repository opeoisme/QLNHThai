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
    public partial class frmDiscount : DevExpress.XtraEditors.XtraForm
    {
        public frmDiscount()
        {
            InitializeComponent();
            {
                GridView gridView = gctDiscount.MainView as GridView;
                gridView.OptionsBehavior.ReadOnly = true;
            }

        }

        QLNHThaiEntities db = new QLNHThaiEntities();
        public void LoadFormDiscount()
        {
            List<Discount> discounts = new List<Discount>();
            discounts = db.Discounts.ToList();
            gctDiscount.DataSource = discounts;
        }
        private void btnLoadDiscount_Click(object sender, EventArgs e)
        {
            LoadFormDiscount();
        }
    }
}