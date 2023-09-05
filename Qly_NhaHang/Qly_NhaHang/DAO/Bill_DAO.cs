using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.DAO
{
    public class Bill_DAO
    {
        QLNHThaiEntities db;

        public Bill_DAO()
        {
            db = new QLNHThaiEntities();
        }


        public Bill getItem(int id)
        {
            return db.Bills.FirstOrDefault(x => x.id_Bill == id);
        }

        public Bill getBillByBan(int idBill, int idBan)
        {
            return db.Bills.FirstOrDefault(x => x.id_Bill == idBill && x.id_Table == idBan);
        }
    }
}
