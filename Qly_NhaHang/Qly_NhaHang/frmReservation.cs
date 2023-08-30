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
    public partial class frmReservation : DevExpress.XtraEditors.XtraForm
    {
        public frmReservation()
        {
            InitializeComponent();

            {
                GridView gridView = gctReservation.MainView as GridView;
                gridView.OptionsBehavior.ReadOnly = true;
            }
        }

        QLNHThaiEntities db = new QLNHThaiEntities();
        public void LoadFormReservation()
        {
            List<Reservation> reservations = new List<Reservation>();
            reservations = db.Reservations.ToList();
            gctReservation.DataSource = reservations;
        }

        private void btnLoadReservation_Click(object sender, EventArgs e)
        {
            LoadFormReservation();
        }
    }
}