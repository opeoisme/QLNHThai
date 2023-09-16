using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.Models
{
    public class CombinedModel
    {
        private string _id_NV;
       
        private int _id_Food;
        public int id_BillInfo { get; set; }
        public int id_Bill { get; set; }
        public int count_Food { get; set; }

        public string name_Food
        {
            get { return GetFoodName(_id_Food); }
            set {  }
        }
        public string name_NV
        {
            get { return GetNVName(_id_NV); }
            set { }
        }


        public decimal price_Food { get; set; }
        public decimal money { get { return price_Food * count_Food; } set { } }
        public int id_Food
        {
            get { return _id_Food; }
            set
            {
                _id_Food = value;
            }
        }
        public DateTime DateCheckIn { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public int id_Table { get; set; }
        public int status_Bill { get; set; }
        public string id_NV
        {
            get { return _id_NV; }
            set
            {
                _id_NV = value;
            }
        }
        public double? totalPrice_Bill { get; set; }
        public double? money_Guest { get; set; }
        public double? money_Change { get; set; }

        // Thêm phương thức để lấy tên món ăn từ ID món ăn
        private string GetFoodName(int foodId)
        {
            using (QLNHThaiEntities db = new QLNHThaiEntities())
            {
                var food = db.Foods.FirstOrDefault(a => a.id_Food == foodId);
                if (food != null)
                {
                    return food.name_Food;
                }
                return string.Empty;
            }
        }

        private string GetNVName(string nhanvienId)
        {
            using (QLNHThaiEntities db = new QLNHThaiEntities())
            {
                var nhanvien = db.NhanViens.FirstOrDefault(a => a.id_NV == nhanvienId);

                if (nhanvien != null)
                {
                    return nhanvien.name_NV;
                }
                return string.Empty;
            }
        }
    }
}
