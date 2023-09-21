using DevExpress.XtraEditors;
using Qly_NhaHang.Models;
using Qly_NhaHang.Report;
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
    public partial class frmPrintBillMain : DevExpress.XtraEditors.XtraForm
    {
        private List<CombinedModel> billInfoData;
        public frmPrintBillMain()
        {
            InitializeComponent();
        }

        public void SetReportData(List<CombinedModel> data)
        {
            BillMain report = new BillMain();
            report.DataSource = data;
            report.lblIdBill.DataBindings.Add("Text", report.DataSource, "id_Bill");
            report.lblIdTable.DataBindings.Add("Text", report.DataSource, "id_Table");
            report.lblDCI.DataBindings.Add("Text", report.DataSource, "DateCheckIn");
            report.lblIdNV.DataBindings.Add("Text", report.DataSource, "name_NV");
            report.lblNameFood.DataBindings.Add("Text", report.DataSource, "name_Food");
            report.lblCountFood.DataBindings.Add("Text", report.DataSource, "count_Food");
            report.lblPriceFood.DataBindings.Add("Text", report.DataSource, "price_Food");
            report.lblTotalPrice.DataBindings.Add("Text", report.DataSource, "total_Price");
            report.lblDCO.DataBindings.Add("Text", report.DataSource, "DateCheckOut");
            report.lblMoneyGuest.DataBindings.Add("Text", report.DataSource, "money_Guest");
            report.lblMoneyChange.DataBindings.Add("Text", report.DataSource, "money_Change");
            dcmvBill.DocumentSource = report;
            report.CreateDocument();
        }
    }
}