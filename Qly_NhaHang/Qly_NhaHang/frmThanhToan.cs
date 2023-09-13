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
            txbTotalBill.Text = String.Format("{0:0,0  }", _total);
            LoadBillInfo();
            LoadDiscountData();
            LoadSurchangeData();
            
            gctSurcharge.DataSource = selectedSurchargeList;
            gctDiscount.DataSource = selectedDiscountList;
            CalculateAndDisplaySurcharge();
            CalculateAndDisplayDiscount();

        }

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


        
        private BindingList<Discount> selectedSurchargeList = new BindingList<Discount>();

        private void btnSurcharge_Click(object sender, EventArgs e)
        {
            string selectedSurchargeName = cbbSurcharge.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedSurchargeName))
            {
                XtraMessageBox.Show("Vui lòng chọn một phụ thu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra xem đã có mục được chọn trước đó hay chưa
            if (IsSurchargeAlreadySelected(selectedSurchargeName))
            {
                XtraMessageBox.Show("Không thể áp dụng 1 loại phụ thu 2 lần", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm đối tượng Discount tương ứng với giá trị được chọn
            var selectedSurcharge = dbContext.Discounts
                .Where(d => d.name_Discount == selectedSurchargeName)
                .FirstOrDefault();

            // Kiểm tra xem đã tìm thấy giảm giá hay không
            if (selectedSurcharge != null)
            {
                // Thêm đối tượng Discount đã chọn vào danh sách
                selectedSurchargeList.Add(selectedSurcharge);
            }
            CalculateAndDisplaySurcharge();
        }

        private bool IsSurchargeAlreadySelected(string discountName)
        {
            return selectedSurchargeList.Any(discount => discount.name_Discount == discountName); 
        }

        private void btnDeleteSurcharge_Click(object sender, EventArgs e)
        {
            GridView gridView = gctSurcharge.MainView as GridView;  // Lấy GridView hiện tại
            if (gridView.SelectedRowsCount > 0)  // Kiểm tra xem có hàng nào được chọn trong GridView không
            {
                int selectedRowHandle = gridView.GetSelectedRows()[0];  // Lấy chỉ mục hàng đầu tiên được chọn
                Discount selectedSurcharge = gridView.GetRow(selectedRowHandle) as Discount;             // Lấy đối tượng Discount tương ứng với hàng được chọn
                if (selectedSurcharge != null)   // Kiểm tra xem đối tượng đã được lấy hay chưa
                {
                    selectedSurchargeList.Remove(selectedSurcharge);  // Xóa đối tượng Discount khỏi danh sách
                    gctSurcharge.RefreshDataSource();    // Cập nhật lại dữ liệu trong gctSurcharge
                }
                CalculateAndDisplaySurcharge();
            }
            else
            {
                XtraMessageBox.Show("Vui lòng chọn một phụ thu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private BindingList<Discount> selectedDiscountList = new BindingList<Discount>();
        private Discount selectedDiscount; 
        private bool hasChanged = false; 

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

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Lấy giá trị hiện tại của txbTotalBill và chuyển nó thành số decimal
            decimal currentTotal = decimal.Parse(txbTotalBill.Text.Replace(",", "").Replace(",", ""));

            // Lấy giá trị của lblMoneySurcharge và chuyển nó thành số decimal
            decimal moneySurcharge = decimal.Parse(lblMoneySurcharge.Text.Replace(",", "").Replace(",", ""));

            // Lấy giá trị của lblMoneyDiscount và chuyển nó thành số decimal
            decimal moneyDiscount = decimal.Parse(lblMoneyDiscount.Text.Replace(",", "").Replace(",", ""));

            // Tính tổng giá trị mới cho txbTotalBill
            decimal newTotal = currentTotal + moneySurcharge + moneyDiscount;

            // Cập nhật giá trị mới vào txbTotalBill
            txbTotalBill.Text = String.Format("{0:0,0 }", newTotal);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txbTotalBill.Text = String.Format("{0:0,0}", _total);
        }

        private void txbMoneyCash_TextChange(object sender, EventArgs e)
        {
            // Kiểm tra xem txbMoneyCash có giá trị hợp lệ không
            if (decimal.TryParse(txbMoneyCash.Text.Replace(",", "").Replace(",", ""), out decimal moneyCash))
            {
                // Lấy giá trị hiện tại của txbTotalBill và chuyển nó thành số decimal
                decimal currentTotal = decimal.Parse(txbTotalBill.Text.Replace(",", "").Replace(",", ""));

                // Tính tiền thừa
                decimal moneyChange = moneyCash - currentTotal;

                // Kiểm tra xem tiền thừa có âm hay không
                if (moneyChange < 0)
                {
                    txbMoneyChange.Text = "CHƯA ĐỦ TIỀN";
                }
                else
                {
                    // Hiển thị tiền thừa trên txbMoneyChange
                    txbMoneyChange.Text = String.Format("{0:0,0 }", moneyChange);
                }
            }
            else
            {
                // Đặt giá trị txbMoneyChange về 0 nếu số tiền không hợp lệ
                txbMoneyChange.Text = "0";
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            UpdateBill();
          UpdateTableStatus();
            CloseFormsAndOpenListTable();
        }

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
    }
}