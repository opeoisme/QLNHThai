using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.Models
{
    public class ViewBillForPay
    {
        private int _id_Food;
        public int id_BillInfo { get; set; }
        public int id_Bill { get; set; }
        public int count_Food { get; set; }
        public String name_Food { get; set; }

        public float price_Food
        {
            get { return _id_Food; }

            set
            {
                _id_Food = (int)value;
                using (QLNHThaiEntities db = new QLNHThaiEntities())
                {
                    price_Food = db.Foods.Where(a => a.id_Food == value).FirstOrDefault().price_Food;
                }
            }
        }

        public int id_Food
        {
            get { return _id_Food; }
            set
            {
                _id_Food = value;
                using (QLNHThaiEntities db = new QLNHThaiEntities())
                {
                    name_Food = db.Foods.Where(a => a.id_Food == value).FirstOrDefault().name_Food;
                }
            }
        }
    }
}
