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
    public partial class SetTable : DevExpress.XtraEditors.XtraUserControl
    {
        string loggedInIdNV = frmLogin.LoggedInIdNV;
        private int _idReservation;
        private int _idTable;
        public int IdTable { get => _idTable; set => _idTable = value; }
        public SetTable()
        {
            InitializeComponent();
        }

        #region method
        public void SetTableData(Tablee table)
        {
            // Cập nhật giao diện với dữ liệu từ bàn (table)
            lblnameTable.Text = table.name_Table;
            lblseatsTable.Text = table.seats_Table.ToString();
            // Cập nhật các thông tin khác tương ứng
            IdTable = table.id_Table;
            _idReservation = new Reservation_DAO().getIdReservationByIDBan(IdTable);
        }
        #endregion


        #region event
        private void btnProfileTable_Click(object sender, EventArgs e)
        {
            frmBookingTable f = new frmBookingTable();
            f.SetIdReservation(_idReservation);
            f.SetIdBan(_idTable);
            f.SetSeatsTable(lblseatsTable.Text);
            f.ShowDialog();
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy Reservation và cập nhật lại trạng thái bàn?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Lấy IdTable và _idReservation của bàn hiện tại
                int idTable = IdTable;

                using (var context = new QLNHThaiEntities()) // Thay thế YourDbContext bằng DbContext của bạn
                {
                    try
                    {
                        // Xóa Reservation tương ứng
                        var reservation = context.Reservations.FirstOrDefault(r => r.id_Reservation == _idReservation);
                        if (reservation != null)
                        {
                            context.Reservations.Remove(reservation);
                            context.SaveChanges();

                            // Xóa thành công Reservation
                            // Cập nhật status_Table của bàn đó thành "Đang trống"
                            var table = context.Tablees.FirstOrDefault(t => t.id_Table == idTable);
                            if (table != null)
                            {
                                table.status_Table = "Đang trống";
                                context.SaveChanges();

                                // Cập nhật thành công status_Table
                                // Thực hiện các tác vụ cần thiết sau khi hủy Reservation và cập nhật trạng thái bàn
                                MessageBox.Show("Đã hủy lịch đặt bàn.");
                                if (Application.OpenForms["frmListTable"] is frmListTable listtableForm)
                                {
                                    listtableForm.loadAll();
                                }
                            }
                            else
                            {
                                // Không tìm thấy bàn
                                MessageBox.Show("Không tìm thấy bàn để cập nhật trạng thái.");
                            }
                        }
                        else
                        {
                            // Không tìm thấy Reservation
                            MessageBox.Show("Không tìm thấy Reservation để hủy.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi
                        MessageBox.Show("Lỗi khi xóa Reservation hoặc cập nhật trạng thái bàn: " + ex.Message);
                    }
                }
            }
        }
        private void btnInsertBill_Click(object sender, EventArgs e)
        {
            string id_NV = loggedInIdNV;   // Lấy id_NV đang đăng nhập 
            DateTime currentTime = DateTime.Now; // Lấy thời gian hiện tại
            int id_Table = _idTable;   // Lấy id_Table đang chọn
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
                frmOrder f = new frmOrder();
                f.SetIdBill(idBill);
                f.SetIdBan(_idTable); // Gán giá trị cho _idBan trước khi mở form frmOrder
                var tableToUpdate = context.Tablees.FirstOrDefault(t => t.id_Table == _idTable);
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
        #endregion
    }
}
