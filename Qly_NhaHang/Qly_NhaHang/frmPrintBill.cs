using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using Qly_NhaHang.Models;
using System.Data.Entity;

namespace Qly_NhaHang
{
    public partial class frmPrintBill : DevExpress.XtraEditors.XtraForm
    {
        private List<CombinedModel> billInfoData;


        public frmPrintBill()
        {
            InitializeComponent();
        }

        //public void ShowReport(List<CombinedModel> data)
        //{
        //    billInfoData = data;
        //    // Tạo và hiển thị báo cáo
        //    HoaDon report = new HoaDon(); // Thay XtraReport1 bằng tên của Report bạn đã tạo
        //    documentViewer1.DocumentSource = report;
        //    report.CreateDocument();
        //}

        public void SetReportData(List<CombinedModel> data)
        {
            HoaDon report = new HoaDon(); 
            report.DataSource = data;
            report.lblIdBill.DataBindings.Add("Text", report.DataSource, "id_Bill");
            report.lblIdTable.DataBindings.Add("Text", report.DataSource, "id_Table");
            report.lblDCI.DataBindings.Add("Text", report.DataSource, "DateCheckIn");
            report.lblIdNV.DataBindings.Add("Text", report.DataSource, "name_NV");
            report.lblNameFood.DataBindings.Add("Text", report.DataSource, "name_Food");
            report.lblCountFood.DataBindings.Add("Text", report.DataSource, "count_Food");
            report.lblPriceFood.DataBindings.Add("Text", report.DataSource, "price_Food");
            report.lblTotalPrice.DataBindings.Add("Text", report.DataSource, "total_Price");
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }




    }
}