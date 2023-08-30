using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.Models
{
    public class FoodModel 
    {
        private int _id_Category;
        public int id_Food { get; set; }
        public string name_Food { get; set; }
        public float price_Food { get; set; }
        public string condition_Food { get; set; }
        public byte[] image_Food { get; set; }
        public String name_Category { get; set; }
        public int id_Category 
        { 
            get { return _id_Category; } 
            set 
            {
                _id_Category = value;
                using (QLNHThaiEntities db = new QLNHThaiEntities())
                {
                    name_Category = db.CategoryFoods.Where(a => a.id_Category == value).FirstOrDefault().name_Category;
                }
            } 
        }
    }
    

}
