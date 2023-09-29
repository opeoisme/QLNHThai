using Qly_NhaHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qly_NhaHang.DAO
{
    public class THONGKE
    {
        public static DateTime GetFirstDayInMonth(int year, int month)
        {
            return new DateTime(year, month, 1);
        }
        public List<DoanhThuModel> DoanhThuTheoNgay()
        {
            DoanhThuModel baocaodoanhthu;
            List<DoanhThuModel> lstDoanhThuTheoNgay = new List<DoanhThuModel>();
            var ngaytra = GetFirstDayInMonth(DateTime.Now.Year, DateTime.Now.Month);


            using (var context = new QLNHThaiEntities())
            {
                var lstdoanhthu = context.FN_DoanhThuTheoNgay(ngaytra, DateTime.Now.AddDays(1)).ToList();
                foreach (var item in lstdoanhthu)
                {
                    if (item != null)
                    {
                        baocaodoanhthu = new DoanhThuModel();
                        baocaodoanhthu.IDDOANHTHU = (int?)item.IDDOANHTHU;
                        baocaodoanhthu.NGAY = item.NGAY;
                        baocaodoanhthu.TONGDOANHTHU = item.TONGDOANHTHU;
                        lstDoanhThuTheoNgay.Add(baocaodoanhthu);
                    }
                    else
                    {
                        
                    }
                }


            }

            return lstDoanhThuTheoNgay;
        }






        public List<TopFood> TopMonan()
        {
            TopFood topsanphamdichvu;
            List<TopFood> lstTopsanpham = new List<TopFood>();


            using (var context = new QLNHThaiEntities())
            {
                var lsttopspdv = context.FN_TopSanPhamDichVu();
                foreach (var item in lsttopspdv)
                {
                    if (item != null)
                    {
                        topsanphamdichvu = new TopFood();
                        topsanphamdichvu.id_Food = item.id_Food;
                        topsanphamdichvu.name_Food = item.name_Food;
                        topsanphamdichvu.SOLUONG = item.SOLUONG;
                        lstTopsanpham.Add(topsanphamdichvu);
                    }
                    else
                    {
                       
                    }
                }


            }

            return lstTopsanpham;
        }


    }
}
