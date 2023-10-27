using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using Qly_NhaHang.DAO;
using Qly_NhaHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmDoanhThuQuy : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmDoanhThuQuy()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
        }
        THONGKE _thongke;

        private string GetQuarterFromMonth(int month)
        {
            switch (month)
            {
                case 1:
                case 2:
                case 3:
                    return "Quý 1";
                case 4:
                case 5:
                case 6:
                    return "Quý 2";
                case 7:
                case 8:
                case 9:
                    return "Quý 3";
                case 10:
                case 11:
                case 12:
                    return "Quý 4";
                default:
                    return "";
            }
        }

        private void frmDoanhThuQuy_Load(object sender, EventArgs e)
        {
            _thongke = new THONGKE();
            //Thong ke tròn
            if (_thongke != null)
            {
                Series _series = new Series("Doanh thu nhà hàng theo quý", ViewType.Pie);
                var lst = _thongke.DoanhThuTheoQuy();

                foreach (var item in lst)
                {
                    if (!string.IsNullOrEmpty(item.QUY))
                    {
                        DateTime date = DateTime.ParseExact(item.QUY, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        int month = date.Month;
                        string quy = GetQuarterFromMonth(month);
                        _series.Points.Add(new SeriesPoint(quy, item.TONGDOANHTHU));
                    }
                }
                cTronQuy.Series.Add(_series);
                _series.Label.TextPattern = "{A}: {VP: P0}";
            }

            Series _series1 = new Series("Doanh thu nhà hàng theo quý", ViewType.Line);
            var lst1 = _thongke.DoanhThuTheoQuy();
            List<SeriesPoint> dataPoints = new List<SeriesPoint>();

            foreach (var item in lst1)
            {
                if (!string.IsNullOrEmpty(item.QUY))
                {
                    DateTime date = DateTime.ParseExact(item.QUY, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    int month = date.Month;
                    string quy = GetQuarterFromMonth(month);
                    dataPoints.Add(new SeriesPoint(quy, item.TONGDOANHTHU));
                }
            }
            _series1.Points.AddRange(dataPoints.ToArray());
            cDuongQuy.Series.Add(_series1);

            Series _series2 = new Series("Doanh thu nhà hàng theo quý", ViewType.Bar);
            var lst2 = _thongke.DoanhThuTheoQuy();
            List<SeriesPoint> dataPoints1 = new List<SeriesPoint>();

            foreach (var item in lst2)
            {
                if (!string.IsNullOrEmpty(item.QUY))
                {
                    DateTime date = DateTime.ParseExact(item.QUY, "M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    int month = date.Month;
                    string quy = GetQuarterFromMonth(month);
                    dataPoints.Add(new SeriesPoint(quy, item.TONGDOANHTHU));
                }
            }
            _series2.Points.AddRange(dataPoints.ToArray());
            cCotQuy.Series.Add(_series2);

            LoadFormThongKeQuy();

        }

        public void LoadFormThongKeQuy()
        {
            DateTime? today = DateTime.Today;
            if (today.HasValue)
            {
                int month = today.Value.Month;

                // Sử dụng hàm GetQuarterFromMonth để xác định quý
                string quy = GetQuarterFromMonth(month);

                // Truy vấn doanh thu dựa trên quý
                var BillData = dbContext.Bills
                    .Where(b => b.status_Bill == 1 && b.DateCheckOut.HasValue &&
                        b.DateCheckOut.Value.Month >= ((month - 1) / 3) * 3 + 1 &&
                        b.DateCheckOut.Value.Month <= ((month - 1) / 3) * 3 + 3)
                    .Select(b => new DoanhThuNgay
                    {
                        id_Bill = b.id_Bill,
                        id_NV = b.id_NV,
                        totalPrice_Bill = b.totalPrice_Bill,
                    }).ToList();

                gctDoanhThuNgay.DataSource = BillData;

                if (BillData.Count == 0)
                {
                    lblTotalMoney.Text = "0 VND";
                }
                else
                {
                    decimal totalMoney = (decimal)BillData.Sum(b => b.totalPrice_Bill);
                    lblTotalMoney.Text = string.Format("{0:N0} VND", totalMoney);
                }
            }
        }


    }
}