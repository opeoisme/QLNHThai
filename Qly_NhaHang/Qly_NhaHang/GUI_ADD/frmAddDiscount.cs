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
            if (string.IsNullOrEmpty(txbNameDiscount.Text) || nmrPercentDIscount.Value <= 4 || cbbTypeDiscount.SelectedItem == null)
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Discount newDiscount = new Discount
            {
                name_Discount = txbNameDiscount.Text,
                percent_Discount = (int)nmrPercentDIscount.Value,
                condition_Discount = "Được áp dụng",
                type_Discount = cbbTypeDiscount.Text

            };

            // Thêm đối tượng mới vào cơ sở dữ liệu
            try
            {
                dbContext.Discounts.Add(newDiscount);
                dbContext.SaveChanges();

                XtraMessageBox.Show("Thêm mới ưu đãi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (Application.OpenForms["frmDiscount"] is frmDiscount discountForm)
                {
                    discountForm.LoadFormDiscount(); // Giả sử tên phương thức là LoadFoodData()
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi khi thêm danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}