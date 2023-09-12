using DevExpress.ChartRangeControlClient.Core;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using Qly_NhaHang.DAO;
using Qly_NhaHang.Models;
using Qly_NhaHang.UserControl;
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

namespace Qly_NhaHang
{
    public partial class frmThanhToan : DevExpress.XtraEditors.XtraForm
    {
        private int _idBill;
        private double _total;
        private QLNHThaiEntities dbContext;
       // THANHTOAN _thanhtoan;
       // int _idDiscount;

        public frmThanhToan(int idBill, double total)
        {
            InitializeComponent();
            InitializeDbContext();
            InitializeGridViewOptions();
            _idBill = idBill;
            _total = total;  
        }

        private void InitializeGridViewOptions()
        {
            GridView gridView = gctSurcharge.MainView as GridView;
            //gridView.OptionsBehavior.ReadOnly = true;
        }
        private void InitializeDbContext()
        {
            dbContext = new QLNHThaiEntities();
        }
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            lblIDBILL.Text = _idBill.ToString();
            //_thanhtoan = new THANHTOAN();
          //  txbTotalBill.Text = _total.ToString();
            txbTotalBill.Text = String.Format("{0:0,0 }", _total);
            LoadBillInfo();
            LoadDiscountData();
            LoadSurchangeData();
           // gctSurcharge.DataSource = GetSurchargeData();

        }

        //private List<Discount> GetSurchargeData()
        //{
        //    // Trả về danh sách dữ liệu phụ thu từ nguồn dữ liệu của bạn
        //    var surchargeData = dbContext.Discounts
        //        .Where(d => d.type_Discount == "Phụ thu")
        //        .ToList();

        //    return surchargeData;
        //}

        //void loadData(int id)
        //{
        //    gctSurcharge.DataSource = new List<Discount> { _thanhtoan.getItem(id) };
        //}

        private void LoadSurchangeData()
        {
            var discount = dbContext.Discounts
                .Where(d => d.type_Discount == "Phụ thu")
                .ToList();

            cbbSurcharge.Properties.Items.Clear(); // Xóa tất cả các mục cũ
            foreach (var item in discount)
            {
                cbbSurcharge.Properties.Items.Add(item.name_Discount);
            }
        }

        private void LoadDiscountData()
        {
            var discount = dbContext.Discounts
                .Where(d => d.type_Discount == "Giảm giá")
                .ToList();

            cbbDiscount.Properties.Items.Clear(); // Xóa tất cả các mục cũ
            foreach (var item in discount)
            {
                cbbDiscount.Properties.Items.Add(item.name_Discount);
            }
        }

        public void LoadBillInfo()
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var billInfoData = dbContext.Bill_Info.Where(bi => bi.id_Bill == _idBill)
                    .Select(f => new BillViewPay
                    {
                        id_Bill = f.id_Bill,
                        id_BillInfo = f.id_BillInfo,
                        count_Food = f.count_Food,
                        id_Food = f.id_Food,
                    })
                    .ToList();

                foreach (var billViewPay in billInfoData)
                {
                    // Lấy giá trị price_Food và tính toán money
                    var food = dbContext.Foods.FirstOrDefault(a => a.id_Food == billViewPay.id_Food);
                    if (food != null)
                    {
                        billViewPay.price_Food = (decimal)food.price_Food;
                        billViewPay.money = billViewPay.price_Food * billViewPay.count_Food;
                    }
                }

                // Gán dữ liệu vào DataSource của gctBill
                gctBill.DataSource = billInfoData;
            }
        }


        // Cần sửa lại
        private List<Discount> selectedSurchargeList = new List<Discount>();
        private void btnSurcharge_Click(object sender, EventArgs e)
        {
            string selectedDiscountName = cbbSurcharge.SelectedItem.ToString();

            // Tìm đối tượng Discount tương ứng với giá trị được chọn
            var selectedDiscount = dbContext.Discounts
                .Where(d => d.name_Discount == selectedDiscountName)
                .FirstOrDefault();

            // Kiểm tra xem đã tìm thấy giảm giá hay không
            if (selectedDiscount != null)
            {
                // Thêm đối tượng Discount đã chọn vào danh sách
                selectedSurchargeList.Add(selectedDiscount);

                // Đặt danh sách đã chọn làm DataSource cho gctSurcharge
                gctSurcharge.DataSource = selectedSurchargeList;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}