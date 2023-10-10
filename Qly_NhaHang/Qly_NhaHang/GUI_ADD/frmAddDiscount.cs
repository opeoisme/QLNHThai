using DevExpress.XtraEditors;
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
    public partial class frmAddDiscount : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext = new QLNHThaiEntities();
        public frmAddDiscount()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNameDiscount.Text) || string.IsNullOrEmpty(txbPercent.Text) || cbbTypeDiscount.SelectedItem == null)
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txbPercent.Text, out int percentValue))
            {
                XtraMessageBox.Show("Phần trăm giảm giá không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Discount newDiscount = new Discount
            {
                name_Discount = txbNameDiscount.Text,
                percent_Discount = percentValue,
                condition_Discount = "Được áp dụng",
                type_Discount = cbbTypeDiscount.Text
            };
            try
            {
                dbContext.Discounts.Add(newDiscount);
                dbContext.SaveChanges();
                XtraMessageBox.Show("Thêm mới ưu đãi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (Application.OpenForms["frmDiscount"] is frmDiscount discountForm)
                {
                    discountForm.LoadFormDiscount();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}