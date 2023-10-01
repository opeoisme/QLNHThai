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
    public partial class frmImport_Info : DevExpress.XtraEditors.XtraForm
    {
        private double lblPriceValue;
        private double count;
        private DateTime? HSD;
        private int quantity;
        public frmImport_Info(string nameFood, string ĐVT, string Unit, double countKid, double count, int idImport ,DateTime? HSD)
        {
            InitializeComponent();
            nmrQuantity.ValueChanged += nmrQuantity_ValueChanged;
            lblID.Text = idImport.ToString();
            lblNameIngredient.Text = nameFood;
            lblĐVT.Text = Unit;
            lblUnit.Text = ĐVT;
            lblUnit1.Text = ĐVT;
            lblCount1.Text = countKid.ToString();
            lblPriceValue = countKid ;
            this.HSD = HSD;
            if (HSD.HasValue)
            {
                dtpkHSD.Value = HSD.Value;
            }
            else
            {
                dtpkHSD.Value = DateTime.Now;
                
            }
            dtpkHSD.Value = (DateTime)HSD;
            this.count = count;
            nmrQuantity.Value = (decimal)count;
            UpdateTotalPrice();
        }

        private void nmrQuantity_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int)(nmrQuantity.Value * 10);
            UpdateTotalPrice();
        }
        private void UpdateTotalPrice()
        {
            double totalPrice = (double)quantity/10 * lblPriceValue;

            lblCount.Text = totalPrice.ToString();
        }

        private void nmrQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Cho phép nhập số, dấu chấm và phím Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Chặn việc nhập nhiều dấu chấm
            if (e.KeyChar == '.' && (sender as NumericUpDown).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                int idIngredient = GetIngredientIdByName(lblNameIngredient.Text);
                string idImportText = lblID.Text;
                int idImportValue = int.Parse(idImportText);
                double totalPrice = (double)quantity / 10 * lblPriceValue; 
                DateTime dateExpiry = dtpkHSD.Value;

                //DateTime? HSD = dtpkHSD.Value;
                if (dateExpiry <= DateTime.Now)
                {
                    XtraMessageBox.Show("Hạn sử dụng phải lớn hơn ngày hiện tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Không tiếp tục thực hiện lưu dữ liệu
                }


                ImportInfo existingImportInfo = dbContext.ImportInfoes
                    .FirstOrDefault(ip => ip.id_Import == idImportValue && ip.id_Ingredient == idIngredient);

                if (existingImportInfo == null)
                {
                  
                    if (count == 0 && quantity == 0)
                    {
                        XtraMessageBox.Show("Vui lòng nhập số lượng món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (count == 0)
                        {
                            ImportInfo newImportInfo = new ImportInfo
                            {
                                id_Import = idImportValue,
                                id_Ingredient = idIngredient,
                                count_Ingredient = (int)totalPrice,
                                date_Expiry = dateExpiry ,

                            };
                            dbContext.ImportInfoes.Add(newImportInfo);
                            dbContext.SaveChanges();
                        }
                    }
                }
                else
                {
                    if (nmrQuantity.Value == 0)
                    {
                        dbContext.ImportInfoes.Remove(existingImportInfo);
                    }
                    else
                    {
                        existingImportInfo.count_Ingredient = (int)totalPrice;
                        existingImportInfo.date_Expiry = dateExpiry;
                    }
                }

                dbContext.SaveChanges();

                this.Close();
                if (Application.OpenForms["frmImport"] is frmImport importForm)
                {
                    importForm.LoadImportInfo(); // Giả sử tên phương thức là LoadFoodData()

                }
            }
        }
        private int GetIngredientIdByName(string nameIngredient)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var ingredient = dbContext.Ingredients.FirstOrDefault(i => i.name_Ingredient == nameIngredient);
                if (ingredient != null)
                {
                    return ingredient.id_Ingredient;
                }
                return -1; // Trả về một giá trị không hợp lệ nếu không tìm thấy món ăn
            }
        }
    }
}