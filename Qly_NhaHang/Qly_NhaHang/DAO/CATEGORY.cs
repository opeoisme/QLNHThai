using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.DAO
{
   public  class CATEGORY
    {
        QLNHThaiEntities db;

        public CATEGORY()
        {
            db = new QLNHThaiEntities();
        }


        public List<CategoryFood> getList(string con)
        {
            return db.CategoryFoods.Where(t => t.condition_Category == con).ToList();
        }

        public List<CategoryFood> getListNB(string con)
        {
            return db.CategoryFoods.Where(t => t.condition_Category == con).ToList();
        }
    }
}
