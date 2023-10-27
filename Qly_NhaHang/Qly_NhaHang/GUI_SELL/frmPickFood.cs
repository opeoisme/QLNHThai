using DevExpress.XtraEditors;
using DocumentFormat.OpenXml.Vml;
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
    public partial class frmPickFood : DevExpress.XtraEditors.XtraForm
    {
        private double lblPriceValue;
        private int quantity ;
        private int foodCount;
        public event EventHandler PickFoodFormClosed;

        public frmPickFood(string nameFood, double priceFood, int idBill, int foodCount)
        {
            InitializeComponent();
            lblNameFood.Text = nameFood;
            lblPrice.Text = lblPrice.Text = String.Format("{0:0,0 vnđ}", priceFood);
            lblPriceValue = priceFood;
            lblID.Text = idBill.ToString();
            this.foodCount = foodCount;
            nmrQuantity.Value = foodCount;
            UpdateTotalPrice();
        }

        private void nmrQuantity_ValueChanged(object sender, EventArgs e)
        {
            quantity = (int)nmrQuantity.Value;
            UpdateTotalPrice();
        }
        private void UpdateTotalPrice()
        {
            double totalPrice = quantity * lblPriceValue;
         
            lblTotalPrice.Text = lblTotalPrice.Text = String.Format("{0:0,0 vnđ}", totalPrice);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                int idFood = GetFoodIdByName(lblNameFood.Text);
                string idBillText = lblID.Text;
                int idBillValue = int.Parse(idBillText);
                Bill_Info existingBillInfo = dbContext.Bill_Info
                    .FirstOrDefault(bi => bi.id_Bill == idBillValue && bi.id_Food == idFood);
                if (existingBillInfo == null)
                {
                    if (foodCount == 0 && quantity == 0)
                    {
                        XtraMessageBox.Show("Vui lòng nhập số lượng món.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (foodCount == 0)
                        {
                            Bill_Info newBillInfo = new Bill_Info
                            {
                                id_Bill = idBillValue,
                                id_Food = idFood,
                                count_Food = quantity
                            };
                            dbContext.Bill_Info.Add(newBillInfo);
                            dbContext.SaveChanges();
                        }
                    }
                }
                else
                {
                    if (nmrQuantity.Value == 0)
                    {
                        dbContext.Bill_Info.Remove(existingBillInfo);
                    }
                    else
                    {
                        existingBillInfo.count_Food = quantity;
                    }
                }
                dbContext.SaveChanges();
                this.Close();
                if (Application.OpenForms["frmOrder"] is frmOrder orderForm)
                {
                    orderForm.LoadBillInfo(); 
                    double total = orderForm.CalculateTotalPrice();
                    orderForm.GetFoodCount(foodCount);
                    orderForm.LoadFoodFLPNTest();
                }
            }
        }



        private int GetFoodIdByName(string nameFood)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var food = dbContext.Foods.FirstOrDefault(f => f.name_Food == nameFood);
                if (food != null)
                {
                    return food.id_Food;
                }
                return -1; 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}