using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using Qly_NhaHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang
{
    public partial class frmThuChiNgay : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmThuChiNgay()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
        }
        THONGKE _thongke;

        private void frmThuChiNgay_Load(object sender, EventArgs e)
        {
            // Biểu đồ tròn
            _thongke = new THONGKE();
            if (_thongke != null)
            {
                Series _series = new Series("Lượng chi nhập hàng theo ngày", ViewType.Pie);
                var lst = _thongke.ThuChiTheoNgay();
                foreach (var item in lst)
                {
                    if (item.NGAY.HasValue) // Kiểm tra xem có giá trị ngày tháng không null
                    {
                        DateTime ngay = item.NGAY.Value;
                        string formattedNgay = ngay.ToString("d/MM/yyyy");

                        _series.Points.Add(new SeriesPoint(formattedNgay, item.TONGDOANHTHU));
                    }

                }
                cChiTron.Series.Add(_series);
                _series.Label.TextPattern = "{A}: {VP: P0}";
            }


            // Biểu đồ cột
            Series _series2 = new Series("Lượng chi nhập hàng theo ngày", ViewType.Bar); // chọn loại biểu đồ là Bar chart
            var lst2 = _thongke.ThuChiTheoNgay();
            foreach (var item in lst2)
            {
                if (item.NGAY.HasValue) // Kiểm tra xem có giá trị ngày tháng không null
                {
                    DateTime ngay = item.NGAY.Value;
                    string formattedNgay = ngay.ToString("d/MM/yyyy");

                    _series2.Points.Add(new SeriesPoint(formattedNgay, item.TONGDOANHTHU));
                }
            }
            _series2.View.Color = Color.FromArgb(68, 173, 170);
            cCotChi.Series.Add(_series2);
            _series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            _series2.Label.TextPattern = "{V:N0} VND";
            ((XYDiagram)cCotChi.Diagram).AxisY.Label.TextPattern = "{V:N0} VND";


            // Biểu đồ đường
            Series _series3 = new Series("Lượng chi nhập hàng theo ngày (Đường)", ViewType.Line);
            var lst3 = _thongke.ThuChiTheoNgay();

            foreach (var item in lst3)
            {
                if (item.NGAY.HasValue)
                {
                    DateTime ngay = item.NGAY.Value;
                    string formattedNgay = ngay.ToString("d/MM/yyyy");

                    _series3.Points.Add(new SeriesPoint(formattedNgay, item.TONGDOANHTHU));
                }
            }
            cDuongChi.Series.Add(_series3);
            _series3.Label.TextPattern = "{A}: {V:N0} VND";
            ((XYDiagram)cDuongChi.Diagram).AxisY.Label.TextPattern = "{V:N0} VND";
        }



    }
}