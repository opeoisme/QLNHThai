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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang.GUI_ADMIN
{
    public partial class frmDoanhThuThang : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmDoanhThuThang()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
        }

        THONGKE _thongke;

        private void frmDoanhThuThang_Load(object sender, EventArgs e)
        {
            // Biểu đồ tròn
            _thongke = new THONGKE();
            if (_thongke != null)
            {
                Series _series = new Series("Doanh thu khách sạn theo ngày", ViewType.Pie);
                var lst = _thongke.DoanhThuTheoThang();
                foreach (var item in lst)
                {
                    if (item.THANG.HasValue) // Kiểm tra xem có giá trị ngày tháng không null
                    {
                        DateTime ngay = item.THANG.Value;
                        string formattedNgay = ngay.ToString("d/MM/yyyy");

                        _series.Points.Add(new SeriesPoint(formattedNgay, item.TONGDOANHTHU));
                    }

                }
                cThangTron.Series.Add(_series);
                _series.Label.TextPattern = "{A}: {VP: P0}";
            }


            // Biểu đồ cột
            Series _series2 = new Series("Doanh thu nhà hàng theo ngày", ViewType.Bar); // chọn loại biểu đồ là Bar chart
            var lst2 = _thongke.DoanhThuTheoThang();
            foreach (var item in lst2)
            {
                if (item.THANG.HasValue) // Kiểm tra xem có giá trị ngày tháng không null
                {
                    DateTime ngay = item.THANG.Value;
                    string formattedNgay = ngay.ToString("d/MM/yyyy");

                    _series2.Points.Add(new SeriesPoint(formattedNgay, item.TONGDOANHTHU));
                }
            }
            _series2.View.Color = Color.FromArgb(68, 173, 170);
            cThangCot.Series.Add(_series2);
            _series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            _series2.Label.TextPattern = "{V:N0} VND";
            ((XYDiagram)cThangCot.Diagram).AxisY.Label.TextPattern = "{V:N0} VND";


            Series _series3 = new Series("Doanh thu khách sạn theo ngày (Đường)", ViewType.Line);
            var lst3 = _thongke.DoanhThuTheoThang();

            foreach (var item in lst3)
            {
                if (item.THANG.HasValue)
                {
                    DateTime ngay = item.THANG.Value;
                    string formattedNgay = ngay.ToString("d/MM/yyyy");

                    _series3.Points.Add(new SeriesPoint(formattedNgay, item.TONGDOANHTHU));
                }
            }
            cThangDuong.Series.Add(_series3);
            _series3.Label.TextPattern = "{A}: {V:N0} VND";
            ((XYDiagram)cThangDuong.Diagram).AxisY.Label.TextPattern = "{V:N0} VND";

            LoadFormBill();
        }

        public void LoadFormBill()
        {
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            var BillData = dbContext.Bills
                .Where(b => b.status_Bill == 1 && b.DateCheckOut.HasValue &&
                    b.DateCheckOut >= firstDayOfMonth && b.DateCheckOut <= lastDayOfMonth)
                .Select(b => new DoanhThuNgay
                {
                    id_Bill = b.id_Bill,
                    id_NV = b.id_NV,
                    totalPrice_Bill = b.totalPrice_Bill,
                }).ToList();

            gctDoanhThuThang.DataSource = BillData;


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