using DevExpress.Data.Utils;
using DevExpress.XtraEditors;
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
    public partial class frmAddCategory : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext = new QLNHThaiEntities();
        public frmAddCategory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbNameCategory.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập thông tin hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CategoryFood newCategory = new CategoryFood
            {
                name_Category = txbNameCategory.Text,
                condition_Category = "Được sử dụng"
                
            };

            // Thêm đối tượng mới vào cơ sở dữ liệu
            try
            {
                dbContext.CategoryFoods.Add(newCategory);
                dbContext.SaveChanges();

                XtraMessageBox.Show("Thêm mới danh sách thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                if (Application.OpenForms["frmCategoryFood"] is frmCategoryFood categoryForm)
                {
                    categoryForm.LoadFormCategory(); // Giả sử tên phương thức là LoadFoodData()
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm danh sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}