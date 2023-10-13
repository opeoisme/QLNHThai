using DevExpress.XtraEditors;
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

namespace Qly_NhaHang.GUI_ADMIN
{
    public partial class frmInventory : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        private int _idImport;
        Import_DAO _import;
        public frmInventory()
        {
            InitializeComponent();

        }
        private void frmInventory_Load(object sender, EventArgs e)
        {
            _import = new Import_DAO();
            lblIDIMPORT.Text = _idImport.ToString();
            LoadCatalogFLPN();
            LoadImportInfo();
        }
        public void SetIdImport(int idImport)
        {
            _idImport = idImport;
        }

        public int GetIngredientCount(int ingredientId)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var exportData = dbContext.ImportInfoes
                    .Where(bi => bi.id_Import == _idImport && bi.id_Ingredient == ingredientId)
                    .Select(f => f.count_Ingredient)
                    .FirstOrDefault();
                return exportData;
            }
        }


        public void LoadCatalogFLPN()
        {
            using (var context = new QLNHThaiEntities()) 
            {
                var CatalogList = context.CatalogIngredients.Where(catalog => catalog.condition_Catalog == "Sử dụng").ToList();
                foreach (var category in CatalogList)
                {
                    Button button = new Button();
                    button.Text = category.name_Catalog;
                    button.Tag = category.id_Catalog;
                    button.BackColor = Color.Teal;
                    button.ForeColor = Color.White;
                    button.Width = 210;
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
                    uctIncentory ingredientControl = new uctIncentory(ingredient.name_Ingredient, ingredient.unit_Ingredient, (double)ingredient.count_Ingredient, GetIngredientCount(ingredient.id_Ingredient), _idImport);
                    ingredientControl.Saved += UctIncentory_Saved;
                    flpnIngredient.Controls.Add(ingredientControl);
                }
            }
        }
        private void UctIncentory_Saved(object sender, EventArgs e)
        {
            // Gọi lại hàm LoadImportInfo
            LoadImportInfo();
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
        private List<ImportInfoViewModel> GetImportInfoData()
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var billInfoData = dbContext.ImportInfoes.Where(bi => bi.id_Import == _idImport)
                    .Select(f => new ImportInfoViewModel
                    {
                        id_Import = f.id_Import,
                        id_ImportInfo = f.id_ImportInfo,
                        count_Ingredient = f.count_Ingredient,
                        id_Ingredient = f.id_Ingredient,
                    })
                    .ToList();
                return billInfoData;
            }
        }
        private bool isIngredientSufficient = true;
        private List<ImportInfoViewModel> previousImportInfoData = new List<ImportInfoViewModel>();
        private List<ImportInfoViewModel> importInfoData = new List<ImportInfoViewModel>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            importInfoData = GetImportInfoData();
            var addedImportInfoItems = importInfoData.Except(previousImportInfoData).ToList();
            var removedImportInfoItems = previousImportInfoData.Except(importInfoData).ToList();
            DialogResult dialogResult = XtraMessageBox.Show("Bạn có muốn chốt sổ không?", "Chốt sổ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                UpdateImportInfoCounts(addedImportInfoItems, removedImportInfoItems);
                XtraMessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                previousImportInfoData = importInfoData;
                this.Close();
                if (Application.OpenForms["frmIngredient"] is frmIngredient ingredientForm)
                {
                    ingredientForm.LoadIngredientData();
                }
            }
        }

        private void UpdateImportInfoCounts(List<ImportInfoViewModel> addedImportInfoItems, List<ImportInfoViewModel> removedBillInfoItems)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var importInfoIds = importInfoData.Select(iid => iid.id_Ingredient).ToList();

                var minDateImport = dbContext.ImportInfoes
                    .Where(ii => ii.Import.type_Import == "Nhập hàng" && importInfoIds.Contains(ii.id_Ingredient) && ii.count_Ingredient > 0)
                    .GroupBy(ii => ii.id_Ingredient)
                    .Select(group => new
                    {
                        IngredientId = group.Key,
                        MinDateImport = group.Min(ii => ii.Import.date_Import)
                    })
                    .OrderBy(item => item.MinDateImport)
                    .FirstOrDefault()?.MinDateImport;

                if (minDateImport != null)
                {
                    UpdateIngredientCounts(addedImportInfoItems, dbContext);
                    UpdateImportInfoCountsForMinDateImport(addedImportInfoItems, removedBillInfoItems, dbContext, minDateImport.Value);

                    dbContext.SaveChanges();
                }
            }
        }


        private void UpdateIngredientCounts(List<ImportInfoViewModel> addedImportInfoItems, QLNHThaiEntities dbContext)
        {
            foreach (var importInfoItem in addedImportInfoItems)
            {
                var ingredient = dbContext.Ingredients.FirstOrDefault(ing => ing.id_Ingredient == importInfoItem.id_Ingredient);
                if (ingredient != null)
                {
                    ingredient.count_Ingredient += importInfoItem.count_Ingredient;
                }
            }
        }

        private void UpdateImportInfoCountsForMinDateImport(List<ImportInfoViewModel> addedImportInfoItems, List<ImportInfoViewModel> removedBillInfoItems, QLNHThaiEntities dbContext, DateTime minDateImport)
        {
            foreach (var importInfoItem in addedImportInfoItems)
            {
                var importInfoToUpdate = dbContext.ImportInfoes
                    .Where(ii => ii.Import.date_Import == minDateImport && ii.Import.type_Import == "Nhập hàng" && ii.count_Ingredient > 0)
                    .ToList()
                    .FirstOrDefault(ii => importInfoData.Any(iid => iid.id_Ingredient == ii.id_Ingredient));

                if (importInfoToUpdate != null)
                {
                    if (importInfoToUpdate.count_Ingredient + importInfoItem.count_Ingredient < 0)
                    {
                        int remainder = importInfoToUpdate.count_Ingredient + importInfoItem.count_Ingredient;
                        importInfoToUpdate.count_Ingredient = 0;
                        MoveRemainderToNextImportInfo(dbContext, minDateImport, importInfoItem.id_Ingredient, remainder);
                    }
                    else
                    {
                        importInfoToUpdate.count_Ingredient += importInfoItem.count_Ingredient;
                    }
                }
            }
        }

        private void MoveRemainderToNextImportInfo(QLNHThaiEntities dbContext, DateTime minDateImport, int ingredientId, int remainder)
        {
            var nextImportInfo = dbContext.ImportInfoes
                .Where(ii => ii.Import.date_Import > minDateImport && ii.Import.type_Import == "Nhập hàng" && ii.id_Ingredient == ingredientId)
                .OrderBy(ii => ii.Import.date_Import)
                .FirstOrDefault();

            if (nextImportInfo != null)
            {
                nextImportInfo.count_Ingredient += remainder;
            }
            else
            {
                
            }
        }
    }
}