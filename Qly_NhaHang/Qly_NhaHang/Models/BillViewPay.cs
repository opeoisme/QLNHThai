using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.Models
{
    public class BillViewPay
    {
        private int _id_Food;
        public int id_BillInfo { get; set; }
        public int id_Bill { get; set; }
        public int count_Food { get; set; }
        public string name_Food { get; set; }
        public decimal price_Food { get; set; }
        public decimal money { get { return price_Food * count_Food; } set { } }
        public int id_Food
        {
            get { return _id_Food; }
            set
            {
                _id_Food = value;
                using (QLNHThaiEntities db = new QLNHThaiEntities())
                {
                    var food = db.Foods.FirstOrDefault(a => a.id_Food == value);
                    if (food != null)
                    {
                        name_Food = food.name_Food;
                        price_Food = (decimal)food.price_Food;
                    }
                }
            }
        }
    }
}
