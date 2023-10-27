using DevExpress.XtraEditors;
using Qly_NhaHang.GUI_ADMIN;
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

namespace Qly_NhaHang.GUI_ADD
{
    public partial class frmAddUnit : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext = new QLNHThaiEntities();
        public frmAddUnit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNameUnit.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Unit newUnit = new Unit
            {
                name_Unit = txbNameUnit.Text,
                condition_Unit = "Sử dụng"
            };
            try
            {
                dbContext.Units.Add(newUnit);
                dbContext.SaveChanges();

                XtraMessageBox.Show("Thêm mới đơn vị tính thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (Application.OpenForms["frmUnit"] is frmUnit unitForm)
                {
                    unitForm.LoadFormUnit(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm đơn vị tính: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}