using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.Models
{
    public class DiscountView
    {
        public int id_Discount { get; set; }
        public string name_Discount { get; set; }
        public int percent_Discount { get; set; }
        public string type_Discount { get; set; }
        public string condition_Discount { get; set; }
    }
}
