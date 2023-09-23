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
        private bool isDiscountSelected = false;
        private BindingList<Discount> selectedSurchargeList = new BindingList<Discount>();
        private BindingList<Discount> selectedDiscountList = new BindingList<Discount>();
        private Discount selectedDiscount;
        private bool hasChanged = false;

        private List<CombinedModel> billInfoData = new List<CombinedModel>();

        public frmThanhToan(int idBill, double total)
        {
            InitializeComponent();
            InitializeDbContext();
            InitializeGridViewOptions();
            _idBill = idBill;
            _total = total;  
        }


        #region Methods
        //GridView
        private void InitializeGridViewOptions()
        {
            GridView gridView = gctSurcharge.MainView as GridView;
        }
        
        //Database
        private void InitializeDbContext()
        {
            dbContext = new QLNHThaiEntities();
        }

        //Lấy dữ liệu phụ thu
        private void LoadSurchangeData()
        {
            var discount = dbContext.Discounts
                .Where(d => d.type_Discount == "Phụ thu" && d.condition_Discount == "Được áp dụng")
                .ToList();

            cbbSurcharge.Properties.Items.Clear(); // Xóa tất cả các mục cũ
            foreach (var item in discount)
            {
                cbbSurcharge.Properties.Items.Add(item.name_Discount);
            }
        }

        //Lấy dữ liệu giảm giá
        private void LoadDiscountData()
        {
            var discount = dbContext.Discounts
                .Where(d => d.type_Discount == "Giảm giá" && d.condition_Discount == "Được áp dụng")
                .ToList();
            cbbDiscount.Properties.Items.Clear(); // Xóa tất cả các mục cũ
            foreach (var item in discount)
            {
                cbbDiscount.Properties.Items.Add(item.name_Discount);
            }
        }

        // Lấy Bill_Info 
        private void LoadBillInfo()
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                billInfoData = dbContext.Bill_Info.Where(bi => bi.id_Bill == _idBill)
                    .Select(f => new CombinedModel
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

        // Tính giá trị Phụ thu
        private void CalculateAndDisplaySurcharge()
        {
            decimal totalSurchargePercent = 0;   // Tính tổng percent_Discount từ danh sách selectedSurchargeList
            foreach (var discount in selectedSurchargeList)
            {
                totalSurchargePercent += discount.percent_Discount;
            }
            decimal moneySurcharge = (totalSurchargePercent / 100) * (decimal)_total;   // Tính giá trị cho lblMoneySurcharge
            moneySurcharge = Math.Round(moneySurcharge / 1000) * 1000; // Làm tròn đến hàng nghìn gần nhất
            lblMoneySurcharge.Text = String.Format("{0:0,0 }", moneySurcharge);  // Hiển thị giá trị trên lblMoneySurcharge
        }

        // Kiểm tra trùng phụ thu
        private bool IsSurchargeAlreadySelected(string discountName)
        {
            return selectedSurchargeList.Any(discount => discount.name_Discount == discountName);
        }
        
        //Tính giá trị khuyến mãi
        private void CalculateAndDisplayDiscount()
        {
            decimal totalDiscountPercent = 0;   // Tính tổng percent_Discount từ danh sách selectedSurchargeList
            foreach (var discount in selectedDiscountList)
            {
                totalDiscountPercent += discount.percent_Discount;
            }
            decimal moneyDiscount = (totalDiscountPercent / -100) * (decimal)_total;   // Tính giá trị cho lblMoneySurcharge
            moneyDiscount = Math.Round(moneyDiscount / 1000) * 1000; // Làm tròn đến hàng nghìn gần nhất
            lblMoneyDiscount.Text = String.Format("{0:0,0 }", moneyDiscount);  // Hiển thị giá trị trên lblMoneySurcharge
        }

        //Kiểm tra giá tiền Cash và tiền Change
        private void UpdateBill()
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                int idBill = int.Parse(lblIDBILL.Text);
                var bill = dbContext.Bills.FirstOrDefault(b => b.id_Bill == idBill);

                if (bill != null)
                {

                    if (string.IsNullOrWhiteSpace(txbMoneyCash.Text) || string.IsNullOrWhiteSpace(txbMoneyChange.Text))
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi xác nhận thanh toán.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Thoát khỏi hàm nếu thiếu thông tin
                    }
                    // Cập nhật các thông tin của Bill
                    bill.DateCheckOut = DateTime.Now;
                    bill.status_Bill = 1; // Đặt status_Bill thành 1
                    decimal totalPrice;
                    decimal moneyGuest;
                    decimal moneyChange;
                    if (decimal.TryParse(txbTotalBill.Text.Replace(",", "").Replace(",", ""), out totalPrice))
                    {
                        bill.totalPrice_Bill = (double?)totalPrice;
                    }
                    if (decimal.TryParse(txbMoneyCash.Text.Replace(",", "").Replace(",", ""), out moneyGuest))
                    {
                        bill.money_Guest = (double?)moneyGuest;
                    }
                    if (decimal.TryParse(txbMoneyChange.Text.Replace(",", "").Replace(",", ""), out moneyChange))
                    {
                        bill.money_Change = (double?)moneyChange;
                    }
                    // Lưu thay đổi vào cơ sở dữ liệu
                    dbContext.SaveChanges();
                }
            }
        }

        //Cập nhật trạng thái BIll
        private void UpdateTableStatus()
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                int idBill = int.Parse(lblIDBILL.Text);
                var bill = dbContext.Bills.FirstOrDefault(b => b.id_Bill == idBill);

                if (bill != null)
                {
                    // Lấy thông tin về bàn từ Bill
                    var table = dbContext.Tablees.FirstOrDefault(t => t.id_Table == bill.id_Table);

                    if (table != null)
                    {
                        // Cập nhật trạng thái của bàn thành "Đang trống"
                        table.status_Table = "Đang trống";

                        // Lưu thay đổi vào cơ sở dữ liệu
                        dbContext.SaveChanges();
                    }
                }
            }
        }

        //Đóng form thanh toán
        private void CloseFormsAndOpenListTable()
        {
            // Đóng form hiện tại (frmThanhToan)
            this.Close();

            // Đóng frmOrder (nếu nó đã được mở)
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in forms)
            {
                if (form.Name == "frmOrder")
                {
                    form.Close();
                }
            }
            if (Application.OpenForms["frmListTable"] is frmListTable listtableForm)
            {
                listtableForm.loadAll();
            }
        }


        private List<CombinedModel> LoadHoaDon()
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var hoaDonData = (from b in dbContext.Bills
                                  join bi in dbContext.Bill_Info on b.id_Bill equals bi.id_Bill
                                  where b.id_Bill == _idBill
                                  select new CombinedModel
                                  {
                                      id_Bill = b.id_Bill,
                                      id_BillInfo = bi.id_BillInfo,
                                      count_Food = bi.count_Food,
                                      id_Food = bi.id_Food,
                                      DateCheckIn = b.DateCheckIn,
                                      DateCheckOut = b.DateCheckOut,
                                      id_Table = b.id_Table,
                                      status_Bill = b.status_Bill,
                                      id_NV = b.id_NV,
                                      totalPrice_Bill = b.totalPrice_Bill,
                                      money_Guest = b.money_Guest,
                                      money_Change = b.money_Change
                                  }).ToList();

                foreach (var hoaDonItem in hoaDonData)
                {
                    // Lấy giá trị price_Food và tính toán money
                    var food = dbContext.Foods.FirstOrDefault(a => a.id_Food == hoaDonItem.id_Food);
                    if (food != null)
                    {
                        hoaDonItem.price_Food = (decimal)food.price_Food;
                        hoaDonItem.money = hoaDonItem.price_Food * hoaDonItem.count_Food;
                    }
                }

                return hoaDonData;
            }
        }


        #endregion




        #region Events
        //Load form Thanh toán
        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            lblIDBILL.Text = _idBill.ToString();
            txbTotalBill.Text = String.Format("{0:0,0  }", _total);
            LoadBillInfo();
            LoadDiscountData();
            LoadSurchangeData();
            gctSurcharge.DataSource = selectedSurchargeList;
            gctDiscount.DataSource = selectedDiscountList;
            CalculateAndDisplaySurcharge();
            CalculateAndDisplayDiscount();
        }

        //Phụ thu
        private void btnSurcharge_Click(object sender, EventArgs e)
        {
            string selectedSurchargeName = cbbSurcharge.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedSurchargeName))
            {
                XtraMessageBox.Show("Vui lòng chọn một phụ thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (IsSurchargeAlreadySelected(selectedSurchargeName))
            {
                XtraMessageBox.Show("Không thể áp dụng 1 loại phụ thu 2 lần", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var selectedSurcharge = dbContext.Discounts
                .Where(d => d.name_Discount == selectedSurchargeName)
                .FirstOrDefault();
            if (selectedSurcharge != null)
            {
                selectedSurchargeList.Add(selectedSurcharge);
            }
            CalculateAndDisplaySurcharge();
        }

        //Xóa phụ thu
        private void btnDeleteSurcharge_Click(object sender, EventArgs e)
        {
            GridView gridView = gctSurcharge.MainView as GridView; 
            if (gridView.SelectedRowsCount > 0)  
            {
                int selectedRowHandle = gridView.GetSelectedRows()[0];  
                Discount selectedSurcharge = gridView.GetRow(selectedRowHandle) as Discount;             
                if (selectedSurcharge != null)   
                {
                    selectedSurchargeList.Remove(selectedSurcharge);  
                    gctSurcharge.RefreshDataSource();
                }
                CalculateAndDisplaySurcharge();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn một phụ thu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Thanh toán
        private void btnPay_Click(object sender, EventArgs e)
        {
            UpdateBill();
            List<CombinedModel> hoaDonData = LoadHoaDon();
            frmPrintBillMain printBillForm = new frmPrintBillMain();
            printBillForm.SetReportData(hoaDonData);
            printBillForm.ShowDialog();
            UpdateTableStatus();
            CloseFormsAndOpenListTable();
        }

        // Thoát
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Giảm giá
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            string selectedDiscountName = cbbDiscount.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedDiscountName))
            {
                XtraMessageBox.Show("Vui lòng chọn một phụ thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var newSelectedDiscount = dbContext.Discounts
                .Where(d => d.name_Discount == selectedDiscountName)
                .FirstOrDefault();
            if (newSelectedDiscount != null)
            {
                if (!hasChanged || newSelectedDiscount.name_Discount != selectedDiscount?.name_Discount)
                {
                    DialogResult result = XtraMessageBox.Show("Áp dụng chương trình khuyến mãi này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    hasChanged = true;
                }
                selectedDiscountList.Clear();
                selectedDiscountList.Add(newSelectedDiscount);
                selectedDiscount = newSelectedDiscount;
                gctDiscount.DataSource = selectedDiscountList;
            }
            CalculateAndDisplayDiscount();
        }

        //Xóa giảm giá
        private void btnDeleteDis_Click(object sender, EventArgs e)
        {
            GridView gridView = gctDiscount.MainView as GridView;  // Lấy GridView hiện tại
            if (gridView.SelectedRowsCount > 0)  // Kiểm tra xem có hàng nào được chọn trong GridView không
            {
                int selectedRowHandle = gridView.GetSelectedRows()[0];  // Lấy chỉ mục hàng đầu tiên được chọn
                Discount selectedDiscount = gridView.GetRow(selectedRowHandle) as Discount;             // Lấy đối tượng Discount tương ứng với hàng được chọn
                if (selectedDiscount != null)   // Kiểm tra xem đối tượng đã được lấy hay chưa
                {
                    selectedDiscountList.Remove(selectedDiscount);  // Xóa đối tượng Discount khỏi danh sách
                    gctDiscount.RefreshDataSource();    // Cập nhật lại dữ liệu trong gctSurcharge
                }
                CalculateAndDisplayDiscount();
            }
            else
            {
                XtraMessageBox.Show("Chưa áp dụng chương trình khuyến mãi nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Áp dụng giảm giá và khuyến mãi
        private void btnApply_Click(object sender, EventArgs e)
        {
            decimal currentTotal = decimal.Parse(txbTotalBill.Text.Replace(",", "").Replace(",", ""));
            decimal moneySurcharge = decimal.Parse(lblMoneySurcharge.Text.Replace(",", "").Replace(",", ""));
            decimal moneyDiscount = decimal.Parse(lblMoneyDiscount.Text.Replace(",", "").Replace(",", ""));
            decimal newTotal = currentTotal + moneySurcharge + moneyDiscount;
            txbTotalBill.Text = String.Format("{0:0,0 }", newTotal);
        }

        // Reload lại tổng Bill
        private void btnReload_Click(object sender, EventArgs e)
        {
            txbTotalBill.Text = String.Format("{0:0,0}", _total);
        }

        //Thay đổi tiền khách trả
        private void txbMoneyCash_TextChange(object sender, EventArgs e)
        {

            if (decimal.TryParse(txbMoneyCash.Text.Replace(",", "").Replace(",", ""), out decimal moneyCash))
            {
                decimal currentTotal = decimal.Parse(txbTotalBill.Text.Replace(",", "").Replace(",", ""));
                decimal moneyChange = moneyCash - currentTotal;
                if (moneyChange < 0)
                {
                    txbMoneyChange.Text = "CHƯA ĐỦ TIỀN";
                }
                else
                {
                    txbMoneyChange.Text = String.Format("{0:0,0 }", moneyChange);
                }
            }
            else
            {
                txbMoneyChange.Text = "0";
            }
        }

        #endregion


        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<CombinedModel> hoaDonData = LoadHoaDon();
            frmPrintBill printBillForm = new frmPrintBill();
            printBillForm.SetReportData(hoaDonData);
            printBillForm.ShowDialog();
            // Hiển thị form in hóa đơn
        }




    }
}