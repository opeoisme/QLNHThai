using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.Models
{
    public class IngredientView
    {
        private int _id_Catalog;
        public int id_Ingredient { get; set; }
        public string name_Ingredient { get; set; }
        public string unit_Ingredient { get; set; }
        public float count_Ingredient { get; set; }
        public string status_Ingredient { get; set; }
        public byte[] image_Ingredient { get; set; }
        public string condition_Ingredient { get; set; }
        public string unitkid_Ingredient { get; set; }
        public float countkid_Ingredient { get; set; }


        public int id_Catalog
        {
            get { return _id_Catalog; }
            set
            {
                _id_Catalog = value;
                using (QLNHThaiEntities db = new QLNHThaiEntities())
                {
                    name_Catalog = db.CatalogIngredients.Where(a => a.id_Catalog == value).FirstOrDefault().name_Catalog;
                }
            }
        }

        public String name_Catalog { get; set; }
    }
}
