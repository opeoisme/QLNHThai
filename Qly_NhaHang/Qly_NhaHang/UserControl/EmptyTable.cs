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
using System.Xml;

namespace Qly_NhaHang.UserControl
{
    public partial class EmptyTable : DevExpress.XtraEditors.XtraUserControl
    {
        private int _idBan;
        string loggedInIdNV = frmLogin.LoggedInIdNV;
        BAN _ban = new BAN();
        private BusyTable _billTable;
        private int idBill;


        public EmptyTable()
        {
            InitializeComponent();
            _billTable = new BusyTable();
        }
        #region method
        public void SetTableData(Tablee table)
        {
            // Cập nhật giao diện với dữ liệu từ bàn (table)
            lblnameTable.Text = table.name_Table;
            lblseatsTable.Text = table.seats_Table.ToString();
            _idBan = table.id_Table;
        }
        #endregion

        #region events

        private void EmptyTable_Load(object sender, EventArgs e)
        {
            _ban = new BAN();
        }

        private void btnInsertBIll_Click(object sender, EventArgs e)
        {
            string id_NV = loggedInIdNV;   // Lấy id_NV đang đăng nhập
            DateTime currentTime = DateTime.Now;  // Lấy thời gian hiện tại
            int id_Table = _idBan;    // Lấy id_Table đang chọn
            using (var context = new QLNHThaiEntities())
            { 
                Bill newBill = new Bill // Tạo một đối tượng Bill mới
                {
                    DateCheckIn = currentTime,
                    id_Table = id_Table,
                    id_NV = id_NV,
                    status_Bill = 0, // Đang có khách (tùy theo thiết kế cơ sở dữ liệu của bạn)                                  
                };
                context.Bills.Add(newBill); // Thêm Bill mới vào cơ sở dữ liệu
                context.SaveChanges();
                int idBill = newBill.id_Bill;
                _billTable.SetBillData(newBill);// Truyền thông tin Bill sang BusyTable
                frmOrder f = new frmOrder();
                f.SetIdBill(idBill);
                f.SetIdBan(_idBan); // Gán giá trị cho _idBan trước khi mở form frmOrder
                var tableToUpdate = context.Tablees.FirstOrDefault(t => t.id_Table == _idBan);
                if (tableToUpdate != null)
                {
                    tableToUpdate.status_Table = "Đang có khách"; // Thay đổi trạng thái của bàn
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                }
                this.Hide();
                f.ShowDialog();
                this.Show();
                (this.ParentForm as frmListTable)?.loadAll();
            }
        }

        private void btnReservationTable_Click(object sender, EventArgs e)
        {
            frmBookingTable f = new frmBookingTable();
            f.SetIdBan(_idBan);
            f.SetSeatsTable(lblseatsTable.Text);
            // Hiển thị frmOrder
            f.ShowDialog();
           
        }
        #endregion
    }
}
