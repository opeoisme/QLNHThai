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
            lblnameTable.Text = table.name_Table; // Cập nhật giao diện với dữ liệu từ bàn (table)
            lblseatsTable.Text = table.seats_Table.ToString();// Cập nhật các thông tin khác tương ứng
            IdTable = table.id_Table;
            _idBill = new Bill_DAO().getIdBillByIDBan(IdTable);
        }


        private void btnBill_Click(object sender, EventArgs e)
        {
            frmOrder f = new frmOrder();
            // Gán giá trị _idBill cho frmOrder
            f.SetIdBill(_idBill);
            f.SetIdBan(_idTable);
           this.ParentForm.Hide();
            // Hiển thị frmOrder
            f.ShowDialog();
            this.ParentForm.Show();
          
        }

        private void btnChangeTable_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện mới của frmOrder
            frmChangeTable f = new frmChangeTable();

            // Gán giá trị _idBill cho frmOrder
            f.SetIdBill(_idBill);
            f.SetIdBan(_idTable);
            //  this.ParentForm.Hide();
            // Hiển thị frmOrder
            f.ShowDialog();
            //this.ParentForm.Show();
        }
    }
}
