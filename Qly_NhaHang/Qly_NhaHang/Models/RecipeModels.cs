using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.Models
{
    public class RecipeModels
    {
        public int id_Recipe { get; set; }
        public int id_Food { get; set; }
        public string name_Ingredient { get; set; }
        
        private int _id_Ingredient;
        public int id_Ingredient 
        {
            get { return _id_Ingredient; }
            set
            {
                _id_Ingredient = value;
                using (QLNHThaiEntities db = new QLNHThaiEntities())
                {
                    name_Ingredient = db.Ingredients.Where(a => a.id_Ingredient == value).FirstOrDefault().name_Ingredient;
                }
            }

        }
        public int count_Ingredient { get; set; }
    }
}
