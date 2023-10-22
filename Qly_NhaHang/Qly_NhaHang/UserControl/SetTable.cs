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
            lblnameTable.Text = table.name_Table;
            lblseatsTable.Text = table.seats_Table.ToString();
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
            DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn hủy Reservation và cập nhật lại trạng thái bàn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idTable = IdTable;
                using (var context = new QLNHThaiEntities()) // Thay thế YourDbContext bằng DbContext của bạn
                {
                    try
                    {
                        var reservation = context.Reservations.FirstOrDefault(r => r.id_Reservation == _idReservation);
                        if (reservation != null)
                        {
                            context.Reservations.Remove(reservation);
                            context.SaveChanges();
                            var table = context.Tablees.FirstOrDefault(t => t.id_Table == idTable);
                            if (table != null)
                            {
                                table.status_Table = "Đang trống";
                                context.SaveChanges();
                                XtraMessageBox.Show("Đã hủy lịch đặt bàn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (Application.OpenForms["frmListTable"] is frmListTable listtableForm)
                                {
                                    listtableForm.loadAll();
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("Lỗi hủy bàn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("Lỗi hủy bàn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa Reservation hoặc cập nhật trạng thái bàn: " + ex.Message);
                    }
                }
            }
        }
        private void btnInsertBill_Click(object sender, EventArgs e)
        {
            string id_NV = loggedInIdNV;   
            DateTime currentTime = DateTime.Now;
            int id_Table = _idTable;  
            using (var context = new QLNHThaiEntities())
            {
                Bill newBill = new Bill 
                {
                    DateCheckIn = currentTime,
                    id_Table = id_Table,
                    id_NV = id_NV,
                    status_Bill = 0,                              
                };
                context.Bills.Add(newBill); 
                context.SaveChanges();
                int idBill = newBill.id_Bill;
                frmOrder f = new frmOrder();
                f.SetIdBill(idBill);
                f.SetIdBan(_idTable); 
                var tableToUpdate = context.Tablees.FirstOrDefault(t => t.id_Table == _idTable);
                if (tableToUpdate != null)
                {
                    tableToUpdate.status_Table = "Đang có khách"; 
                    context.SaveChanges();
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
