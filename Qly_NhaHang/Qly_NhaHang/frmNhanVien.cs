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
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
            {
                GridView gridView = gctNV.MainView as GridView;
                gridView.OptionsBehavior.ReadOnly = true;
            }
        }

        QLNHThaiEntities db = new QLNHThaiEntities();
        public void LoadFormNV()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            nhanViens = db.NhanViens.ToList();
            gctNV.DataSource = nhanViens;
        }

        private void btnLoadTable_Click(object sender, EventArgs e)
        {
            LoadFormNV();
        }
    }
}