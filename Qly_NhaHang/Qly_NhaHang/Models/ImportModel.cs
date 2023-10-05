using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.Models
{
    public class ImportModel
    {
        public int id_Import { get; set; }
        public System.DateTime? date_Import { get; set; }
        public string _id_NV;
        public float total_Price { get; set; }
        public string name_NV { get; set; }
        public string status_Import { get; set; }
        public string id_NV
        {
            get { return _id_NV; }
            set
            {
                _id_NV = value;
                using (QLNHThaiEntities db = new QLNHThaiEntities())
                {
                    name_NV = db.NhanViens.Where(a => a.id_NV == value).FirstOrDefault().name_NV;
                }
            }
        }
    }
}
