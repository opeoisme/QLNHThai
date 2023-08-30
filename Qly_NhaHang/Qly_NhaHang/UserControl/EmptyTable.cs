using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Qly_NhaHang.UserControl
{
    public partial class EmptyTable : DevExpress.XtraEditors.XtraUserControl
    {
        public EmptyTable()
        {
            InitializeComponent();
        }
        public void SetTableData(Tablee table)
        {
            // Cập nhật giao diện với dữ liệu từ bàn (table)
            lblnameTable.Text = table.name_Table;
            lblseatsTable.Text = table.seats_Table.ToString();
            // Cập nhật các thông tin khác tương ứng
        }

        private void btnInsertBIll_Click(object sender, EventArgs e)
        {
            frmOrder f = new frmOrder();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
