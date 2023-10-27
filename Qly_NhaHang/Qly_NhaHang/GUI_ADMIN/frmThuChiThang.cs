using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using Qly_NhaHang.DAO;
using Qly_NhaHang.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang.GUI_ADMIN
{
    public partial class frmThuChiThang : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmThuChiThang()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
        }
        THONGKE _thongke;

        private void frmThuChiThang_Load(object sender, EventArgs e)
        {
            // Biểu đồ tròn
            _thongke = new THONGKE();
            if (_thongke != null)
            {
                Series _series = new Series("Lượng chi nhập nguyên liệu theo tháng", ViewType.Pie);
                var lst = _thongke.ThuChiTheoThang();
                foreach (var item in lst)
                {
                    if (item.THANG.HasValue) // Kiểm tra xem có giá trị ngày tháng không null
                    {
                        DateTime ngay = item.THANG.Value;
                        string formattedNgay = ngay.ToString("d/MM/yyyy");

                        _series.Points.Add(new SeriesPoint(formattedNgay, item.TONGDOANHTHU));
                    }

                }
                cChiTron.Series.Add(_series);
                _series.Label.TextPattern = "{A}: {VP: P0}";
            }


            Series _series2 = new Series("\"Lượng chi theo tháng", ViewType.Bar); // chọn loại biểu đồ là Bar chart
            var lst2 = _thongke.ThuChiTheoThang();
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
            cCotThang.Series.Add(_series2);
            _series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            _series2.Label.TextPattern = "{V:N0} VND";
            ((XYDiagram)cCotThang.Diagram).AxisY.Label.TextPattern = "{V:N0} VND";


            Series _series3 = new Series("Lượng chi theo tháng (Đường)", ViewType.Line);
            var lst3 = _thongke.ThuChiTheoThang();
            foreach (var item in lst3)
            {
                if (item.THANG.HasValue)
                {
                    DateTime ngay = item.THANG.Value;
                    string formattedNgay = ngay.ToString("d/MM/yyyy");

                    _series3.Points.Add(new SeriesPoint(formattedNgay, item.TONGDOANHTHU));
                }
            }
            cDuongThang.Series.Add(_series3);
            _series3.Label.TextPattern = "{A}: {V:N0} VND";
            ((XYDiagram)cDuongThang.Diagram).AxisY.Label.TextPattern = "{V:N0} VND";

            LoadFormImport();
        }




        public void LoadFormImport()
        {
            DateTime today = DateTime.Today;
            DateTime firstDayOfMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);

            var ImportData = dbContext.Imports
                .Where(b => b.type_Import == "Nhập hàng" && b.date_Import.HasValue &&
                    b.date_Import >= firstDayOfMonth && b.date_Import <= lastDayOfMonth)
                .Select(b => new ThuChiNgay
                {
                    id_Import = b.id_Import,
                    id_NV = b.id_NV,
                    total_Price = b.total_Price,
                }).ToList();

            gctThuChiThang.DataSource = ImportData;


            if (ImportData.Count == 0)
            {
                lblTotalMoney.Text = "0 VND";
            }
            else
            {
                decimal totalMoney = (decimal)ImportData.Sum(b => b.total_Price);
                lblTotalMoney.Text = string.Format("{0:N0} VND", totalMoney);
            }
        }
    }
}