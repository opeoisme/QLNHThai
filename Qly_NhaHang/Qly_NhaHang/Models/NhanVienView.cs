using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.Models
{
    public class NhanVienView
    {
        public string id_NV { get; set; }
        public string name_NV { get; set; }
        public string sex_NV { get; set; }
        public string address_NV { get; set; }
        public string CCCD_NV { get; set; }
        public string phone_NV { get; set; }
        public string pass_NV { get; set; }
        public byte[] image_NV { get; set; }
        public string type_NV { get; set; }
        public string condition_NV { get; set; }
    }
}
