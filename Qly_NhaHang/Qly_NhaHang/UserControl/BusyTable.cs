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
        private int _idBill;
        private int _idTable;

        public int IdTable { get => _idTable; set => _idTable = value; }

        public BusyTable()
        {
            InitializeComponent();
        }
      
        private void BusyTable_Load(object sender, EventArgs e)
        {

        }

        public void SetBillData(Bill bill)
        {
            _idBill = bill.id_Bill;
        }


        public void SetTableData(Tablee table)
        {
            lblnameTable.Text = table.name_Table; 
            lblseatsTable.Text = table.seats_Table.ToString();
            IdTable = table.id_Table;
            _idBill = new Bill_DAO().getIdBillByIDBan(IdTable);
        }


        private void btnBill_Click(object sender, EventArgs e)
        {
            frmOrder f = new frmOrder();
            f.SetIdBill(_idBill);
            f.SetIdBan(_idTable);
            f.ShowDialog();
          
          
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            frmChangeTable f = new frmChangeTable();
            f.SetIdBill(_idBill);
            f.SetIdBan(_idTable);
            f.ShowDialog();
        }
    }
}
