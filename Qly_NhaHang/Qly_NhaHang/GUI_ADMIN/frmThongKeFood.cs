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

namespace Qly_NhaHang.GUI_ADMIN
{
    public partial class frmThongKeFood : DevExpress.XtraEditors.XtraForm
    {
        public frmThongKeFood()
        {
            InitializeComponent();
        }
        THONGKE _thongke;
        private void frmThongKeFood_Load(object sender, EventArgs e)
        {
            _thongke = new THONGKE();
            if (_thongke != null)
            {
                Series _series = new Series("Top 5 sản phẩm dịch vụ bán chạy nhất", ViewType.Pie);
                var lst = _thongke.TopMonan();
                foreach (var item in lst)
                {
                    _series.Points.Add(new SeriesPoint(item.name_Food, item.SOLUONG));

                }
                cTronTopFood.Series.Add(_series);
                _series.Label.TextPattern = "{A}: {VP: P0}";
            }


            Series _series2 = new Series("Top 5 sản phẩm dịch vụ bán chạy nhất", ViewType.Bar); // chọn loại biểu đồ là Bar chart
            var lst2 = _thongke.TopMonan();
            foreach (var item in lst2)
            {
                _series2.Points.Add(new SeriesPoint(item.name_Food, item.SOLUONG));
                
            }
            _series2.View.Color = Color.FromArgb(68, 173, 170);
            cCotTopFood.Series.Add(_series2);
            _series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            _series2.Label.TextPattern = "{A}: {VP: P0}";



            Series _series3 = new Series("\"Top 5 sản phẩm dịch vụ bán chạy nhất", ViewType.Line);
            var lst3 = _thongke.TopMonan();

            foreach (var item in lst3)
            {
                _series3.Points.Add(new SeriesPoint(item.name_Food, item.SOLUONG));
            }
            cDuongTopFood.Series.Add(_series3);
            _series3.Label.TextPattern = "{A}: {VP: P0}";


            Series _series4 = new Series("\"Top 5 sản phẩm dịch vụ bán chạy nhất", ViewType.Area);
            var lst4 = _thongke.TopMonan();

            foreach (var item in lst3)
            {
                _series4.Points.Add(new SeriesPoint(item.name_Food, item.SOLUONG));
            }
            cMienTopFood.Series.Add(_series4);
            _series4.Label.TextPattern = "{A}: {VP: P0}";

        }
    }
}