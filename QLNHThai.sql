﻿create database QLNHThai

use QLNHThai

-- tao bang
create table NhanVien (
	id_NV char(10) primary key,
	name_NV nvarchar(max) not null,
	sex_NV nvarchar(10) ,
	address_NV nvarchar(max) not null, 
	CCCD_NV char(12) not null,
	phone_NV char(10) not null,
	pass_NV varchar(10) not null default 1,
	image_NV varbinary(max),
	type_NV nvarchar(max) not null default N'Nhân viên', 
	condition_NV nvarchar(max) default N'Làm việc'
)

create table Tablee (
	id_Table int identity primary key,
	name_Table nvarchar(50) not null,
	status_Table nvarchar(max) default N'Đang trống' not null,
	seats_Table int default 2,
	condition_Table nvarchar (max) default N'Được sử dụng'
)

 create table CategoryFood (
	id_Category int identity primary key,
	name_Category nvarchar(50) not null,
	condition_Category nvarchar(50)
)

create table Food (
	id_Food int identity primary key,
	name_Food nvarchar(50) not null , 
	id_Category int not null, 
	price_Food float not null,
	image_Food varbinary(max),
	condition_Food nvarchar(max) default N'Được sử dụng'
	foreign key (id_Category) references CategoryFood (id_Category)
)

create table Bill (
	id_Bill int identity primary key,
	DateCheckIn Date not null default getdate(), 
	DateCheckOut Date, 
	id_Table int not null,
	status_Bill int not null default 0,
	id_NV char(10) not null,
	totalPrice_Bill float, 
	foreign key (id_Table) references Tablee (id_Table), 
	foreign key (id_NV) references NhanVien (id_NV), 
)

create table Bill_Info(
	id_BillInfo int identity primary key,
	id_Bill int not null,
	id_Food int not null, 
	count_Food int not null default 0
	foreign key (id_Bill) references Bill (id_Bill),
	foreign key (id_Food) references Food (id_Food)
)

create table Discount(
	id_Discount int identity primary key,
	name_Discount nvarchar(max) not null,
	percent_Discount int not null, 
	type_Discount nvarchar(max) not null 
)

create table Reservation(
	id_Reservation int identity primary key,
	name_Guest nvarchar(max) not null,
	date_Reservation datetime not null, 
	phone_Guest char(10) not null,
	id_Table int, 
	foreign key (id_Table) references Tablee (id_Table)
)

create table Import(
	id_Import int identity primary key,
	date_Import date not null, 
	id_NV char(10) not null,
	type_Import nvarchar(max),
	foreign key (id_NV) references NhanVien (id_NV)
)

create table Ingredient(
	id_Ingredient int identity primary key,
	name_Ingredient nvarchar(max) not null,
	unit_Ingredient nvarchar(max) not null,
	count_Ingredient int not null,
	comment_Ingredient nvarchar(max)
)

create table ImportInfo(
	id_ImportInfo int identity primary key,
	id_Import int not null,
	id_Ingredient int not null,
	count_Ingredient int not null,
	type_Import nvarchar(max),
	expỉry_Import int, 
	date_Expiry date,
	foreign key (id_Import) references Import (id_Import),
	foreign key (id_Ingredient) references Ingredient (id_Ingredient)
)

 create table CatalogIngredient (
	id_Catalog int identity primary key,
	name_Catalalog nvarchar(50) not null,
	condition_Catalog nvarchar(50)
)

create table Recipe(
	id_Recipe int identity primary key,
	id_Food int not null,
	id_Ingredient int not null,
	count_Ingredient int not null,
	foreign key (id_Food) references Food (id_Food),
	foreign key (id_Ingredient) references Ingredient (id_Ingredient)
)
 
select *from Bill_Info
select * from Ingredient
select *from CatalogIngredient

CREATE FUNCTION dbo.FN_DoanhThuTheoNgay
(
    @checkIn datetime,
    @checkOut datetime
)
RETURNS TABLE
AS
RETURN
(
    SELECT ROW_NUMBER() OVER (ORDER BY CONVERT(date, DateCheckOut )) AS IDDOANHTHU,
           CONVERT(date, DateCheckOut) AS NGAY,
           SUM(totalPrice_Bill) AS TONGDOANHTHU
    FROM Bill
    WHERE CONVERT(date, DateCheckIn) >= CONVERT(date, @checkIn)
        AND CONVERT(date, DateCheckOut) <= CONVERT(date, @checkOut)
        AND status_Bill = 1
    GROUP BY CONVERT(date, DateCheckOut)
);



CREATE FUNCTION dbo.FN_TopSanPhamDichVu()
RETURNS @TopSellingProducts TABLE (
    id_Food int,
    name_Food nvarchar(200),
    SOLUONG int
)
AS
BEGIN
    INSERT INTO @TopSellingProducts (id_Food, name_Food, SOLUONG)
    SELECT TOP 5 sp.id_Food , sp.name_Food , SUM(dp.count_Food) AS SOLUONG
    FROM Bill_Info dp
    INNER JOIN Food sp ON dp.id_Food = sp.id_Food
    GROUP BY sp.id_Food, sp.name_Food
    ORDER BY SOLUONG DESC

    RETURN
END

SELECT TOP 3 sp.id_Food , sp.name_Food, SUM(dp.count_Food) AS SOLUONG
FROM Bill_Info dp
INNER JOIN Food sp ON dp.id_Food = sp.id_Food
GROUP BY sp.id_Food, sp.name_Food
ORDER BY SOLUONG DESC



select* from Ingredient
select *from Bill_Info

select *from Import
select* from ImportInfo

DBCC CHECKIDENT (Import, RESEED, 1);
