﻿using DevExpress.XtraEditors;
using Qly_NhaHang.DAO;
using Qly_NhaHang.Models;
using Qly_NhaHang.UserControl;
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
    public partial class frmImport : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        private int _idImport;
        Import_DAO _import;
        public frmImport()
        {
            InitializeComponent();
           
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            _import = new Import_DAO();
            lblIDBILL.Text = _idImport.ToString();
            LoadIngredientFLPN();
            LoadCatalogFLPN();
            LoadImportInfo();
        }

        public void SetIdImport(int idImport)
        {
            _idImport = idImport;
        }

        public DateTime? GetIngredientDate(int ingredientId)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var importInfoData = dbContext.ImportInfoes
                    .Where(ip => ip.id_Import == _idImport && ip.id_Ingredient == ingredientId)
                    .Select(f => f.date_Expiry)
                    .FirstOrDefault();
                return importInfoData;
            }
        }
        public double GetIngredientCount(int ingredientId)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var billInfoData = dbContext.ImportInfoes
                     .Where(ip => ip.id_Import == _idImport && ip.id_Ingredient == ingredientId)
                    .Select(f => f.count_Ingredient)
                    .FirstOrDefault();
                return billInfoData;
            }
        }

        public void LoadIngredientFLPN()
        {
            using (var context = new QLNHThaiEntities())
            {
                var IngredientList = (from ingredient in context.Ingredients
                                join catalog in context.CatalogIngredients
                                on ingredient.id_Catalog equals catalog.id_Catalog
                                where ingredient.condition_Ingredient == "Sử dụng" && catalog.condition_Catalog == "Sử dụng"
                                select ingredient).ToList();
                foreach (var nguyenlieu in IngredientList)
                {
                    // Tạo instance của user control và thêm vào FlowLayoutPanel
                    var Ingredientct = new uctIngredient( nguyenlieu.name_Ingredient, nguyenlieu.unitkid_Ingredient ,nguyenlieu.unit_Ingredient, nguyenlieu.countkid_Ingredient.GetValueOrDefault(),_idImport ,GetIngredientDate(nguyenlieu.id_Ingredient), GetIngredientCount(nguyenlieu.id_Ingredient));
                    flpnIngredient.Controls.Add(Ingredientct);
                }
            }
        }


        public void LoadCatalogFLPN()
        {
            using (var context = new QLNHThaiEntities()) // Thay "YourDbContext" bằng context của bạn
            {
                var CatalogList = context.CatalogIngredients.Where(catalog => catalog.condition_Catalog == "Sử dụng").ToList();
                foreach (var category in CatalogList)
                {
                    Button button = new Button();
                    button.Text = category.name_Catalog;
                    button.Tag = category.id_Catalog;
                    button.BackColor = Color.Teal; 
                    button.ForeColor = Color.White; 
                    button.Width = 230; 
                    button.Height = 72;
                    button.Click += CategoryButton_Click;
                    flpnCatalog.Controls.Add(button);
                }
            }
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int catalogId = (int)clickedButton.Tag;
            DisplayIngredientsByCategory(catalogId);
        }

        private void DisplayIngredientsByCategory(int catalogId)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var ingredientInCatalog = dbContext.Ingredients.Where(ingredient => ingredient.id_Catalog == catalogId && ingredient.condition_Ingredient == "Sử dụng").ToList();
                flpnIngredient.Controls.Clear();
                foreach (var ingredient in ingredientInCatalog)
                {
                    uctIngredient ingredientControl = new uctIngredient(ingredient.name_Ingredient,ingredient.unitkid_Ingredient, ingredient.unit_Ingredient, ingredient.countkid_Ingredient.GetValueOrDefault(), _idImport, GetIngredientDate(ingredient.id_Ingredient), GetIngredientCount(ingredient.id_Ingredient));
                    flpnIngredient.Controls.Add(ingredientControl);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadImportInfo()
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var importInfoData = dbContext.ImportInfoes.Where(ip => ip.id_Import == _idImport)
                    .Select(f => new ImportInfoViewModel
                    {
                        id_Import = f.id_Import,
                        id_ImportInfo = f.id_ImportInfo,
                        count_Ingredient = f.count_Ingredient,
                        date_Expiry = f.date_Expiry,
                        id_Ingredient = f.id_Ingredient,
                    })
                    .ToList();
                gctImport.DataSource = importInfoData;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ gctImport
            List<ImportInfoViewModel> importInfoData = gctImport.DataSource as List<ImportInfoViewModel>;

            // Kiểm tra xem importInfoData có bị trống không
            if (importInfoData != null && importInfoData.Count > 0)
            {
                using (var dbContext = new QLNHThaiEntities())
                {
                    foreach (var importInfo in importInfoData)
                    {
                        // Tìm nguyên liệu trong bảng Ingredients dựa vào tên (name_Ingredient)
                        var ingredient = dbContext.Ingredients.FirstOrDefault(i => i.name_Ingredient == importInfo.name_Ingredient);

                        if (ingredient != null)
                        {
                            // Cộng thêm count_Ingredient từ importInfo vào count_Ingredient của nguyên liệu
                            ingredient.count_Ingredient += importInfo.count_Ingredient;
                        }
                    }
                    dbContext.SaveChanges();
                    this.Close();
                    if (Application.OpenForms["frmIngredient"] is frmIngredient ingredientForm)
                    {
                        ingredientForm.LoadIngredientData();
                    }
                }
            }
            else
            {
                // GctImport trống, thực hiện thông báo hoặc xử lý khác tùy theo yêu cầu của bạn
                XtraMessageBox.Show("Bạn chưa nhập bất kì loại hàng nào!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

    }
}