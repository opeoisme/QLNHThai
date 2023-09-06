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


        public EmptyTable()
        {
            InitializeComponent();
            _billTable = new BusyTable();
        }

        private void EmptyTable_Load(object sender, EventArgs e)
        {
            _ban = new BAN();
        }
        public void SetTableData(Tablee table)
        {
            // Cập nhật giao diện với dữ liệu từ bàn (table)
            lblnameTable.Text = table.name_Table;
            lblseatsTable.Text = table.seats_Table.ToString();
            _idBan = table.id_Table;
        }

        private void btnInsertBIll_Click(object sender, EventArgs e)
        {
            // Lấy id_NV đang đăng nhập (giả sử bạn đã lưu thông tin này khi người dùng đăng nhập)
            string id_NV = loggedInIdNV;

            // Lấy thời gian hiện tại
            DateTime currentTime = DateTime.Now;

            // Lấy id_Table đang chọn
            int id_Table = _idBan;

            using (var context = new QLNHThaiEntities())
            {
                // Tạo một đối tượng Bill mới
                Bill newBill = new Bill
                {
                    DateCheckIn = currentTime,
                    id_Table = id_Table,
                    id_NV = id_NV,
                    status_Bill = 0, // Đang có khách (tùy theo thiết kế cơ sở dữ liệu của bạn)                                  
                };

                // Thêm Bill mới vào cơ sở dữ liệu
                context.Bills.Add(newBill);
                context.SaveChanges();

                int idBill = newBill.id_Bill;
                _billTable.SetBillData(newBill);// Truyền thông tin Bill sang BusyTable

            }

            frmOrder f = new frmOrder();
            // Gán giá trị cho _idBan trước khi mở form frmOrder
            f.SetIdBan(_idBan);
            using (var context = new QLNHThaiEntities())
            {
                var tableToUpdate = context.Tablees.FirstOrDefault(t => t.id_Table == _idBan);
                if (tableToUpdate != null)
                {
                    tableToUpdate.status_Table = "Đang có khách"; // Thay đổi trạng thái của bàn
                    context.SaveChanges(); // Lưu thay đổi vào cơ sở dữ liệu
                }
            }
            this.Hide();
            f.ShowDialog();
            this.Show();
            (this.ParentForm as frmListTable)?.loadAll();
        }

       

    }
}
