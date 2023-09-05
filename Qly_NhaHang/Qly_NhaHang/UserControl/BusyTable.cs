using DevExpress.XtraEditors;
using Qly_NhaHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang.UserControl
{
    public partial class BusyTable : DevExpress.XtraEditors.XtraUserControl
    {
        private int _idbill;
        public BusyTable()
        {
            InitializeComponent();
        }

        Bill_DAO _bill = new Bill_DAO();
        public void SetTableData(Tablee table)
        {
            // Cập nhật giao diện với dữ liệu từ bàn (table)
            lblnameTable.Text = table.name_Table;
            lblseatsTable.Text = table.seats_Table.ToString();
            // Cập nhật các thông tin khác tương ứng
           

        }

        public void SetBillData(Bill bill)
        {
            _idbill = bill.id_Bill;
        }


        private void btnBill_Click(object sender, EventArgs e)
        {
            int id_bill = _idbill;
            frmOrder f = new frmOrder();
            f.SetIdBill(id_bill); // Truyền giá trị _idbill cho frmOrder
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void BusyTable_Load(object sender, EventArgs e)
        {
            _bill = new Bill_DAO();
        }
    }
}
