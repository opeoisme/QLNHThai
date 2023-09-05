using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.DAO
{
    public class BAN
    {
        QLNHThaiEntities db;
        
        public BAN()
        {
            db = new QLNHThaiEntities();
        }
       

        public Tablee getItem(int id)
        {
            return db.Tablees.FirstOrDefault(x => x.id_Table == id);
        }
    }
}
