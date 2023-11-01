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

namespace Qly_NhaHang
{
    public partial class frmBookingTable : DevExpress.XtraEditors.XtraForm
    {
        private int _idBan;
        BAN _ban;
        private int _idReservation;
        Reservation_DAO _reservation;

        private QLNHThaiEntities dbContext;
        private bool IsUpdateMode = false;
        public frmBookingTable()
        {
            InitializeComponent();
        }

        private void frmBookingTable_Load(object sender, EventArgs e)
        {
            _ban = new BAN();
            lblID.Text = _idBan.ToString(); 
            _reservation = new Reservation_DAO();
            if (_idReservation != 0)
            {
                IsUpdateMode = true;
                LoadReservationData();
            }
        }

        private void LoadReservationData()
        {
            try
            {
                using (var context = new QLNHThaiEntities())
                {
                    var reservation = context.Reservations.FirstOrDefault(r => r.id_Reservation == _idReservation );
                    if (reservation != null)
                    {
                        txbGuestName.Text = reservation.name_Guest;
                        txbGuestPhone.Text = reservation.phone_Guest;
                        TimeSpan timeZoneOffset = TimeSpan.FromHours(7);
                        dtpkTimeGuest.DateTimeOffset = new DateTimeOffset(reservation.date_Reservation, timeZoneOffset);
                    }
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi tải thông tin đặt bàn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void SetIdBan(int idBan)
        {
            _idBan = idBan;
        }

        public void SetIdReservation(int idReservation)
        {
            _idReservation = idReservation;
        }

        public void SetSeatsTable(string seatsTable)
        {
            lblSeats.Text = seatsTable; 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int idTable = int.Parse(lblID.Text);
                string nameGuest = txbGuestName.Text;
                DateTimeOffset dateReservation = dtpkTimeGuest.DateTimeOffset;
                string phoneGuest = txbGuestPhone.Text;
                if (string.IsNullOrWhiteSpace(nameGuest))
                {
                    XtraMessageBox.Show("Vui lòng nhập tên khách hàng.","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (phoneGuest.Length != 10 || !int.TryParse(phoneGuest, out _))
                {
                    XtraMessageBox.Show("Vui lòng nhập số điện thoại khách hàng.","Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                if (dateReservation == default(DateTimeOffset) || dateReservation <= DateTimeOffset.Now)
                {
                    XtraMessageBox.Show("Vui lòng chọn một ngày và giờ đặt bàn hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }
             
                DateTime dateReservationLocal = TimeZoneInfo.ConvertTimeFromUtc(dateReservation.UtcDateTime, TimeZoneInfo.Local);
                using (var context = new QLNHThaiEntities())
                {
                    if (IsUpdateMode) 
                    {
                        var reservationToUpdate = context.Reservations.FirstOrDefault(r => r.id_Reservation == _idReservation );
                        if (reservationToUpdate != null)
                        {
                            reservationToUpdate.name_Guest = nameGuest;
                            reservationToUpdate.date_Reservation = dateReservationLocal;
                            reservationToUpdate.phone_Guest = phoneGuest;
                        }
                    }
                    else 
                    {
                        Reservation newReservation = new Reservation
                        {
                            id_Table = idTable,
                            name_Guest = nameGuest,
                            date_Reservation = dateReservationLocal,
                            phone_Guest = phoneGuest,
                            status_Reservatione = 0
                            
                        };

                        context.Reservations.Add(newReservation);
                        var tableToUpdate = context.Tablees.FirstOrDefault(t => t.id_Table == idTable);
                        if (tableToUpdate != null)
                        {
                            tableToUpdate.status_Table = "Được đặt";
                        }
                    }
                    context.SaveChanges();
                }
                XtraMessageBox.Show(IsUpdateMode ? "Cập nhật đặt bàn thành công!" : "Đặt bàn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (Application.OpenForms["frmListTable"] is frmListTable listtableForm)
                {
                    listtableForm.loadAll();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi đặt bàn" + ex.Message);
            }
        }

    }
}