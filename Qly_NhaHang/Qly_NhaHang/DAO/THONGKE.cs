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






        public List<DoanhThuThangModel> DoanhThuTheoThang()
        {
            DoanhThuThangModel baocaodoanhthu;
            List<DoanhThuThangModel> lstDoanhThuTheoThang = new List<DoanhThuThangModel>();

            using (var context = new QLNHThaiEntities())
            {
                var currentYear = DateTime.Now.Year; // Năm hiện tại
                var startYear = 2023; // Năm bắt đầu thống kê (có thể thay đổi)

                for (int year = startYear; year <= currentYear; year++)
                {
                    for (int month = 1; month <= 12; month++)
                    {
                        var startDate = new DateTime(year, month, 1);
                        var endDate = startDate.AddMonths(1).AddDays(-1);

                        var doanhthuThang = context.FN_DoanhThuTheoThang(startDate, endDate).ToList();

                        baocaodoanhthu = new DoanhThuThangModel();
                        baocaodoanhthu.THANG = startDate;

                        if (doanhthuThang.Count > 0)
                        {
                            baocaodoanhthu.TONGDOANHTHU = doanhthuThang.Sum(doanhthu => doanhthu.TONGDOANHTHU);
                        }
                        else
                        {
                            baocaodoanhthu.TONGDOANHTHU = 0;
                        }
                        lstDoanhThuTheoThang.Add(baocaodoanhthu);
                    }
                }
            }

            return lstDoanhThuTheoThang;
        }

    }
}
