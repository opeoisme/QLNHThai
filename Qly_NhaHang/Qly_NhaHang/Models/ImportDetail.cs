using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.Models
{
    public class ImportDetail
    {
        public int id_ImportInfo { get; set; }
        public int id_Import { get; set; }
        public int _id_Ingredient;
        public string name_Ingredient { get; set; }
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
        public DateTime? date_Expiry { get; set; }

        public virtual Import Import { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
