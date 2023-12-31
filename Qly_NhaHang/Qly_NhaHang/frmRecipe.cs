﻿using DevExpress.XtraEditors;
using FuzzyString;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FuzzyString;
using Qly_NhaHang.UserControl;
using DevExpress.XtraGrid.Views.Grid;
using DocumentFormat.OpenXml.Bibliography;
using Qly_NhaHang.Models;

namespace Qly_NhaHang
{
    public partial class frmRecipe : DevExpress.XtraEditors.XtraForm
    {
        private QLNHThaiEntities dbContext;
        private int selectedFoodId;
        public frmRecipe()
        {
            InitializeComponent();
            dbContext = new QLNHThaiEntities();
        }

        #region methods
        public int GetIngredientCount(int ingredientId)
        {
            using (var dbContext = new QLNHThaiEntities())
            {
                var recipeData = dbContext.Recipes
                    .Where(bi => bi.id_Food == selectedFoodId && bi.id_Ingredient == ingredientId)
                    .Select(f => f.count_Ingredient)
                    .FirstOrDefault();
                return recipeData;
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
                    var Ingredientct = new uctRecipeIngredient(nguyenlieu.name_Ingredient, nguyenlieu.unit_Ingredient, GetIngredientCount(nguyenlieu.id_Ingredient), selectedFoodId);
                    flpnIngredient.Controls.Add(Ingredientct);
                }
            }
        }
        public void LoadFoodFLPN()
        {
            using (var context = new QLNHThaiEntities())
            {
                var FoodList = context.Foods.Where(food => food.condition_Food == "Được sử dụng").ToList();
                foreach (var food in FoodList)
                {
                    Button button = new Button();
                    button.Text = food.name_Food;
                    button.Tag = food.id_Food;
                    button.BackColor = Color.Teal;
                    button.ForeColor = Color.White;
                    button.Width = 260;
                    button.Height = 72;
                    button.Click += FoodButton_Click;
                    flpnFood.Controls.Add(button);
                }
            }
        }
        public void LoadDataRecipe()
        {
            var categoryData = dbContext.Recipes
                            .Where(recipe => recipe.id_Food == selectedFoodId)
                            .Select(f => new RecipeModels
                            {
                                id_Recipe = f.id_Ingredient,
                                id_Food = f.id_Food,
                                id_Ingredient = f.id_Ingredient,
                                count_Ingredient = f.count_Ingredient,
                            }).ToList();
            gctRecipe.DataSource = categoryData;
        }
        public void LoadIngredientFLPNTest()
        {
            flpnIngredient.Controls.Clear();
            using (var context = new QLNHThaiEntities())
            {
                var IngredientList = (from ingredient in context.Ingredients
                                      join catalog in context.CatalogIngredients
                                      on ingredient.id_Catalog equals catalog.id_Catalog
                                      where ingredient.condition_Ingredient == "Sử dụng" && catalog.condition_Catalog == "Sử dụng"
                                      select ingredient).ToList();
                foreach (var nguyenlieu in IngredientList)
                {
                    var Ingredientct = new uctRecipeIngredient(nguyenlieu.name_Ingredient, nguyenlieu.unit_Ingredient, GetIngredientCount(nguyenlieu.id_Ingredient), selectedFoodId);
                    flpnIngredient.Controls.Add(Ingredientct);
                }
            }
        }
        #endregion


        #region events
        private void frmRecipe_Load(object sender, EventArgs e)
        {
            LoadFoodFLPN();
            LoadIngredientFLPN();
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            string searchText = txbSearchFood.Text.Trim();
            using (var context = new QLNHThaiEntities())
            {
                var filteredFoodList = context.Foods
                    .Where(food => food.condition_Food == "Được sử dụng" && food.name_Food.Contains(searchText))
                    .ToList();
                flpnFood.Controls.Clear();
                foreach (var food in filteredFoodList)
                {
                    Button button = new Button();
                    button.Text = food.name_Food;
                    button.Tag = food.id_Food;
                    button.BackColor = Color.Teal;
                    button.ForeColor = Color.White;
                    button.Width = 260;
                    button.Height = 72;
                    button.Click += FoodButton_Click;
                    flpnFood.Controls.Add(button);
                }
            }
        }

        private void FoodButton_Click(object sender, EventArgs e)
        {
            if (sender is Button foodButton)
            {
                string foodName = foodButton.Text;
                lblNameFood.Text = foodName;
                selectedFoodId = (int)foodButton.Tag;
                LoadDataRecipe();
                flpnIngredient.Controls.Clear();
                LoadIngredientFLPN();
            }
        }

        private void btnSearchIngredient_Click(object sender, EventArgs e)
        {
            string searchText = txbSearchIngredient.Text.Trim(); 
            using (var context = new QLNHThaiEntities())
            {
                var filteredIngredientList = context.Ingredients
                    .Where(ingredient => ingredient.condition_Ingredient == "Sử dụng" && ingredient.name_Ingredient.Contains(searchText) )
                    .ToList();
                flpnIngredient.Controls.Clear();

                foreach (var ingredient in filteredIngredientList)
                {
                    uctRecipeIngredient ingredientControl = new uctRecipeIngredient(ingredient.name_Ingredient, ingredient.unit_Ingredient, GetIngredientCount(ingredient.id_Ingredient), selectedFoodId);
                    flpnIngredient.Controls.Add(ingredientControl);
                }
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}