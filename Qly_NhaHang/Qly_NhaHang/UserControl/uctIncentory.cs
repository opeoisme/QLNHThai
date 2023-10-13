using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qly_NhaHang.UserControl
{
    public partial class uctIncentory : DevExpress.XtraEditors.XtraUserControl
    {
        private int ingredientCount;
        private string nameIngredient;
        private string unitIngredient;
        private double count;
        private int quantity;
        private double lblCountValue;
        private int idImport;
        public event EventHandler Saved;

        public uctIncentory(string nameIngredient, string unitIngredient, double count, int ingredientCount, int idImport)
        {
            InitializeComponent();
            this.idImport = idImport;
            this.nameIngredient = nameIngredient;
            lblIngredientName.Text = nameIngredient;
            this.unitIngredient = unitIngredient;
            lblUnit.Text = unitIngredient;
            lblUnit1.Text = unitIngredient;
            lblUnit2.Text = unitIngredient;
            this.count = count;
            lblQuantity.Text = count.ToString();
            lblCountValue = count;


            this.ingredientCount = ingredientCount;
           // nmrQuantityReal.Value = ingredientCount;


            using (var dbContext = new QLNHThaiEntities())
            {
                var ingredient = dbContext.Ingredients.FirstOrDefault(i => i.name_Ingredient == nameIngredient);
                if (ingredient != null && ingredient.image_Ingredient != null)
                {
                    using (MemoryStream ms = new MemoryStream(ingredient.image_Ingredient))
                    {
                        imageIngredient.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    // Load ảnh mặc định từ tài nguyên
                    imageIngredient.Image = Properties.Resources.Food0;
                }
            }

            
        }

        private void nmrQuantityReal_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int)nmrQuantityReal.Value;
            UpdateTotalPrice();
        }
        private void UpdateTotalPrice()
        {
            double totalPrice = quantity - lblCountValue;

            lblCount.Text = totalPrice.ToString();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                int idIngredient = GetIngredientIdByName(lblIngredientName.Text);
                double totalCount = quantity - lblCountValue;
                ImportInfo existingImportInfo = dbContext.ImportInfoes
                    .FirstOrDefault(ip => ip.id_Import == idImport && ip.id_Ingredient == idIngredient);

                if (existingImportInfo == null)
                {

                    if (count == 0 && quantity == 0)
                    {
                        XtraMessageBox.Show("Vui lòng nhập số lượng món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if ((double)nmrQuantityReal.Value != count)
                        {
                            ImportInfo newImportInfo = new ImportInfo
                            {
                                id_Import = idImport,
                                id_Ingredient = idIngredient,
                                count_Ingredient = (int)totalCount,
                                date_Expiry = null,
                            };
                            dbContext.ImportInfoes.Add(newImportInfo);
                            dbContext.SaveChanges();
                        }
                    }
                }
                else
                {
                    if ((double)nmrQuantityReal.Value == count)
                    {
                        dbContext.ImportInfoes.Remove(existingImportInfo);
                    }
                    else
                    {
                        existingImportInfo.count_Ingredient = (int)totalCount;
                    }
                }
                dbContext.SaveChanges();
                OnSaved(EventArgs.Empty);
            }
        }

        protected virtual void OnSaved(EventArgs e)
        {
            Saved?.Invoke(this, e);
        }
    }
}
