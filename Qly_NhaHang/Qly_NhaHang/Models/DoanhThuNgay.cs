using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.Models
{
    public class DoanhThuNgay
    {
        public string _id_NV;
        public int id_Bill { get; set; }
        public System.DateTime DateCheckIn { get; set; }
        public Nullable<System.DateTime> DateCheckOut { get; set; }
        public int id_Table { get; set; }
        public string name_NV { get; set; }
        public int status_Bill { get; set; }
        public Nullable<double> totalPrice_Bill { get; set; }
        public Nullable<double> money_Guest { get; set; }
        public Nullable<double> money_Change { get; set; }
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
