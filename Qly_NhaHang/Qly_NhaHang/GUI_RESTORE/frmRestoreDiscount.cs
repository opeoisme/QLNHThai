using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace Qly_NhaHang
{
    public partial class frmRestoreDiscount : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        public frmRestoreDiscount()
        {
            InitializeComponent();
            InitializeGridViewOptions();
            dbContext = new QLNHThaiEntities(); // Khởi tạo dbContext ở đây
        }

        private void InitializeGridViewOptions()
        {
            GridView gridView = gctDiscount.MainView as GridView;
            gridView.OptionsBehavior.ReadOnly = true;
            gridView.FocusedRowChanged += gvDiscount_FocusedRowChanged;
        }
        public void LoadFormDiscount()
        {
            var discountData = dbContext.Discounts
                              .Where(dc => dc.condition_Discount == "Hết chương trình")
                             .Select(dc => new DiscountView
                             {
                                 id_Discount = dc.id_Discount,
                                 name_Discount = dc.name_Discount,
                                 percent_Discount = dc.percent_Discount,
                                 type_Discount = dc.type_Discount,
                                 condition_Discount = dc.condition_Discount,

                             }).ToList();
            gctDiscount.DataSource = discountData;
        }

        private void frmRestoreDiscount_Load(object sender, EventArgs e)
        {
            LoadFormDiscount();
        }

        private void btnLoadCategory_Click(object sender, EventArgs e)
        {
            LoadFormDiscount();
        }

        private void gvDiscount_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                UpdateDiscountControls(e.FocusedRowHandle);
            }
        }
        private void UpdateDiscountControls(int focusedRowHandle)
        {
            DiscountView selectedDiscount = gvDiscount.GetRow(focusedRowHandle) as DiscountView;
            if (selectedDiscount != null)
            {
                txbIdDiscount.Text = selectedDiscount.id_Discount.ToString();
                txbNameDiscount.Text = selectedDiscount.name_Discount;
                txbPercentDiscount.Text = selectedDiscount.percent_Discount.ToString();
                cbbTypeDiscount.Text = selectedDiscount.type_Discount;
              
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            int focusedRowHandle = gvDiscount.FocusedRowHandle;
            if (focusedRowHandle >= 0)
            {
                DiscountView selectedDiscount = gvDiscount.GetRow(focusedRowHandle) as DiscountView;
                if (selectedDiscount != null)
                {
                    if (int.TryParse(selectedDiscount.id_Discount.ToString(), out int discountId))
                    {
                        Discount discountToUpdate = dbContext.Discounts.FirstOrDefault(dc => dc.id_Discount == discountId);

                        if (discountToUpdate != null)
                        {
                            discountToUpdate.condition_Discount = "Được áp dụng";

                            // Đánh dấu đối tượng là thay đổi
                            dbContext.Entry(discountToUpdate).State = EntityState.Modified;

                            // Lưu thay đổi
                            dbContext.SaveChanges();

                            // Nạp lại dữ liệu sau khi cập nhật
                            LoadFormDiscount();
                            XtraMessageBox.Show("Chương trình được đưa vào hoạt động trở lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}