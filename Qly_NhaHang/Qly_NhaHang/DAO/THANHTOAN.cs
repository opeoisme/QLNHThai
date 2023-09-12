using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.DAO
{
    public class THANHTOAN
    {
        QLNHThaiEntities db;
        public THANHTOAN()
        {
            db = new QLNHThaiEntities();
        }


        public Discount getItem(int id)
        {
            return db.Discounts.FirstOrDefault(x => x.id_Discount == id);
        }

        public List<Discount> getAll()
        {
            return db.Discounts.ToList();
        }
    }
}
