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






        public List<ThuChiModel> ThuChiTheoNgay()
        {
            ThuChiModel baocaothuchi;
            List<ThuChiModel> lstThuChiTheoNgay = new List<ThuChiModel>();
            var ngaytra = GetFirstDayInMonth(DateTime.Now.Year, DateTime.Now.Month);
            using (var context = new QLNHThaiEntities())
            {
                var lstthuchi = context.FN_ThuChiTheoNgay(ngaytra).ToList();

                foreach (var item in lstthuchi)
                {
                    if (item != null)
                    {
                        baocaothuchi = new ThuChiModel();
                        baocaothuchi.IDDOANHTHU = (int?)item.IDDOANHTHU;
                        baocaothuchi.NGAY = item.NGAY;
                        baocaothuchi.TONGDOANHTHU = item.TONGDOANHTHU;
                        lstThuChiTheoNgay.Add(baocaothuchi);
                    }
                    else
                    {

                    }
                }
            }
            return lstThuChiTheoNgay;
        }



        public List<ThuChiThang> ThuChiTheoThang()
        {
            ThuChiThang baocaodoanhthu;
            List<ThuChiThang> lstDoanhThuTheoThang = new List<ThuChiThang>();

            using (var context = new QLNHThaiEntities())
            {
                var currentYear = DateTime.Now.Year; 
                var startYear = 2023; 
                for (int year = startYear; year <= currentYear; year++)
                {
                    for (int month = 1; month <= 12; month++)
                    {
                        var startDate = new DateTime(year, month, 1);
                        var endDate = startDate.AddMonths(1).AddDays(-1);

                        var thuchiThang = context.FN_ThuChiTheoThang(startDate).ToList();
                        baocaodoanhthu = new ThuChiThang();
                        baocaodoanhthu.THANG = startDate;

                        if (thuchiThang.Count > 0)
                        {
                            baocaodoanhthu.TONGDOANHTHU = thuchiThang.Sum(doanhthu => doanhthu.TONGDOANHTHU);
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




        public List<baocaodoanhthuQuyDTO> DoanhThuTheoQuy()
        {
            baocaodoanhthuQuyDTO baocaodoanhthu;
            List<baocaodoanhthuQuyDTO> lstDoanhThuTheoQuy = new List<baocaodoanhthuQuyDTO>();

            using (var context = new QLNHThaiEntities())
            {
                var currentYear = DateTime.Now.Year; // Năm hiện tại
                var startYear = 2023; // Năm bắt đầu thống kê (có thể thay đổi)

                for (int year = startYear; year <= currentYear; year++)
                {
                    for (int quarter = 1; quarter <= 4; quarter++) // Lặp qua 4 quý trong năm
                    {
                        // Xác định ngày đầu và ngày cuối của quý
                        var startDate = new DateTime(year, (quarter - 1) * 3 + 1, 1);
                        var endDate = startDate.AddMonths(3).AddDays(-1);

                        // Gọi function để lấy doanh thu theo quý
                        var doanhthuQuy = context.FN_DoanhThuTheoQuy(startDate, endDate).FirstOrDefault();

                        baocaodoanhthu = new baocaodoanhthuQuyDTO();
                        baocaodoanhthu.QUY = startDate.ToString();

                        if (doanhthuQuy != null)
                        {
                            baocaodoanhthu.TONGDOANHTHU = doanhthuQuy.TONGDOANHTHU;
                        }
                        else
                        {
                            baocaodoanhthu.TONGDOANHTHU = 0;
                        }
                        lstDoanhThuTheoQuy.Add(baocaodoanhthu);
                    }
                }
            }


            return lstDoanhThuTheoQuy;
        }

    }
}
