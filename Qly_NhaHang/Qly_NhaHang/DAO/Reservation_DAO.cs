using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.DAO
{
    public class Reservation_DAO
    {
        QLNHThaiEntities db;

        public Reservation_DAO()
        {
            db = new QLNHThaiEntities();
        }

         public int getIdReservationByIDBan(int idBan)
        {
            return db.Reservations.Where(r => r.id_Table == idBan && r.status_Reservatione == 0 ).FirstOrDefault().id_Reservation;
        }
    }
}
