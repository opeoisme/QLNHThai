using DevExpress.XtraEditors;
using Qly_NhaHang.DAO;
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
    public partial class frmChangeTable : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext = new QLNHThaiEntities();
        private int _idBan;
        private int _idBill;
        BAN _ban;
        Bill_DAO _bill;
        public frmChangeTable()
        {
            InitializeComponent();
        }

        private void frmChangeTable_Load(object sender, EventArgs e)
        {
            _ban = new BAN();
            lblIDTable.Text = _idBan.ToString(); // Cập nhật lblID.Text bằng giá trị _idBan
            _bill = new Bill_DAO();
            lblIdBill.Text = _idBill.ToString();
            LoadTableData();
        }

        private void LoadTableData()
        {
            // Lấy id_Table của bàn đang chọn hiện tại
            int selectedTableId = _idBan;

            // Lọc danh sách bàn để loại bỏ bàn đang chọn
            var categories = dbContext.Tablees
                .Where(table => table.status_Table != "Được đặt" && table.id_Table != selectedTableId)
                .ToList();
            // Gán danh sách bàn đã lọc làm nguồn dữ liệu cho ComboBox
            cbbNewTable.DataSource = categories;
            cbbNewTable.DisplayMember = "id_Table";
            cbbNewTable.ValueMember = "id_Table";
        }


        public void SetIdBill(int idBill)
        {
            _idBill = idBill;
        }

        public void SetIdBan(int idBan)
        {
            _idBan = idBan;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int newTableId = Convert.ToInt32(cbbNewTable.SelectedValue);
            var newTable = dbContext.Tablees.FirstOrDefault(table => table.id_Table == newTableId);

            if (newTable != null)
            {
                if (newTable.status_Table == "Đang trống")
                {
                    // Xác nhận chuyển bàn
                    DialogResult result = XtraMessageBox.Show("Bạn muốn chuyển bàn chứ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MoveTable(newTableId);
                    }
                }
                else if (newTable.status_Table == "Đang có khách")
                {
                    // Xác nhận gộp bàn
                    DialogResult result = XtraMessageBox.Show("Hai bàn này đang có đơn. Bạn muốn gộp bàn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MergeTables(newTableId);
                    }
                }
            }
        }

        private void MoveTable(int newTableId)
        {
            var billToUpdate = dbContext.Bills.FirstOrDefault(bill => bill.id_Bill == _idBill);
            var oldTable = dbContext.Tablees.FirstOrDefault(table => table.id_Table == _idBan);
            var newTable = dbContext.Tablees.FirstOrDefault(table => table.id_Table == newTableId);

            if (billToUpdate != null && oldTable != null && newTable != null)
            {
                billToUpdate.id_Table = newTableId;
                oldTable.status_Table = "Đang trống";
                newTable.status_Table = "Đang có khách"; // Cập nhật status_Table của bàn mới

                dbContext.SaveChanges();

                CloseFormAndRefreshListTable();
            }
        }

        private void MergeTables(int newTableId)
        {
            var billA = dbContext.Bills.Include(b => b.Bill_Info).FirstOrDefault(bill => bill.id_Bill == _idBill);
            var billB = dbContext.Bills.Include(b => b.Bill_Info).FirstOrDefault(bill => bill.id_Table == newTableId && bill.status_Bill == 0);

            if (billA != null && billB != null)
            {

                foreach (var billAInfo in billA.Bill_Info.ToList())
                {
                    var billBInfo = billB.Bill_Info.FirstOrDefault(info => info.id_Food == billAInfo.id_Food);
                    if (billBInfo != null)
                    {
                        billBInfo.count_Food += billAInfo.count_Food;
                    }
                    else
                    {
                        AddBillInfoToBillB(billB, billAInfo);
                    }

                    dbContext.Bill_Info.Remove(billAInfo);
                }

                dbContext.Bills.Remove(billA);
                var tableA = dbContext.Tablees.FirstOrDefault(table => table.id_Table == _idBan);
                if (tableA != null)
                {
                    tableA.status_Table = "Đang trống";
                }

                dbContext.SaveChanges();

                CloseFormAndRefreshListTable();
            }
        }

        private void AddBillInfoToBillB(Bill billB, Bill_Info billAInfo)
        {
            var billBBillId = billB.id_Bill;
            var newBillInfo = new Bill_Info
            {
                id_Bill = billBBillId,
                id_Food = billAInfo.id_Food,
                count_Food = billAInfo.count_Food
            };
            billB.Bill_Info.Add(newBillInfo);
        }

        private void CloseFormAndRefreshListTable()
        {
            this.Close();
            if (Application.OpenForms["frmListTable"] is frmListTable listtableForm)
            {
                listtableForm.loadAll();
            }
        }

    }
}