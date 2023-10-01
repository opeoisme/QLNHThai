﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Qly_NhaHang
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QLNHThaiEntities : DbContext
    {
        public QLNHThaiEntities()
            : base("name=QLNHThaiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<Bill_Info> Bill_Info { get; set; }
        public virtual DbSet<CatalogIngredient> CatalogIngredients { get; set; }
        public virtual DbSet<CategoryFood> CategoryFoods { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Tablee> Tablees { get; set; }
        public virtual DbSet<ImportInfo> ImportInfoes { get; set; }
        public virtual DbSet<Import> Imports { get; set; }
    
        [DbFunction("QLNHThaiEntities", "FN_DoanhThuTheoNgay")]
        public virtual IQueryable<FN_DoanhThuTheoNgay_Result> FN_DoanhThuTheoNgay(Nullable<System.DateTime> checkIn, Nullable<System.DateTime> checkOut)
        {
            var checkInParameter = checkIn.HasValue ?
                new ObjectParameter("checkIn", checkIn) :
                new ObjectParameter("checkIn", typeof(System.DateTime));
    
            var checkOutParameter = checkOut.HasValue ?
                new ObjectParameter("checkOut", checkOut) :
                new ObjectParameter("checkOut", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FN_DoanhThuTheoNgay_Result>("[QLNHThaiEntities].[FN_DoanhThuTheoNgay](@checkIn, @checkOut)", checkInParameter, checkOutParameter);
        }
    
        [DbFunction("QLNHThaiEntities", "FN_TopSanPhamDichVu")]
        public virtual IQueryable<FN_TopSanPhamDichVu_Result> FN_TopSanPhamDichVu()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<FN_TopSanPhamDichVu_Result>("[QLNHThaiEntities].[FN_TopSanPhamDichVu]()");
        }
    }
}
