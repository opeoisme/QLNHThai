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
    }
}
