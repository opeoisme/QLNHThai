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
    public partial class frmAddSupplier : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext = new QLNHThaiEntities();
        public frmAddSupplier()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNameSupplier.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Supplier newSupplier = new Supplier
            {
                name_Supplier = txbNameSupplier.Text,
                condition_Supplier = "Hợp tác",
                note_Supplier = txbNote.Text,
            };
            try
            {
                dbContext.Suppliers.Add(newSupplier);
                dbContext.SaveChanges();

                XtraMessageBox.Show("Thêm mới nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (Application.OpenForms["frmSupplier"] is frmSupplier supplierForm)
                {
                    supplierForm.LoadFormSupplier();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}