--KuzeyYeli

/*
	Categories
	Products
	Suppliers
	Orders
	Employees
	Customers
	Shippers


	Order Details

*/

--DDL
create database KuzeyYeli
go
use KuzeyYeli
go


--mevcut olan bir tablo adýný deðiþtirmek için sistem tarafýnda kayýtlý olan bir "stored procedure" kullanmamýz gerekmektedir.

Exec sp_rename 'Kategoriler','Categories' --tablo adýný deðiþtiren sp



--Categories Table
create table Categories(
CategoryId int primary key identity (1,1),
CategoryName nvarchar(255) not null,
Description nvarchar(255),


);
--Category Data


--Alter Table
alter table Categories
add Picture image 

alter table Categories
drop column Picture


select * from Categories

go


--Products Table
create table Products(
ProductId int primary key identity (1,1),
CategoryId int foreign key references Categories(CategoryId),
ProductName nvarchar(255) not null,
UnitPrice money not null,
UnitsInStock smallint not null,
discontinued bit
)

--Product Data



create table Employees(
EmployeeId int primary key identity (1,1),
ReportsTo int foreign key references Employees(EmployeeId),
Lastname nvarchar(20) not null,
Firstname nvarchar(10) not null,
Title nvarchar(30) not null,
TitleOfCourse nvarchar(20) not null,
)
go


-- customer
create table Customers(
CustomerId nchar(5) primary key ,
Companyname nvarchar(40) not null,
Contactname nvarchar(30)  null,
Adress nvarchar(60)  null,
City nvarchar(15) null,
)
go
--Shipper
create table Shippers(
ShipperId int primary key identity (1,1),
CompanyName nvarchar(40) not null,
)



---Orders
go
create table Orders(
OrdersId int primary key identity (1,1),
CustomerId nchar(5) foreign key references Customers(CustomerId),
EmployeeId int foreign key references Employees(EmployeeId),
Orderdate datetime null,
ShippVia int foreign key references Shippers(ShipperId),

)
go
--OrderDetails
create table OrderDetails(
OrderId int not null Foreign key references Orders (OrdersId),
ProductId int not null Foreign key references Products (ProductId),
Primary key (OrderId,ProductId),--composite key
Quantity smallint not null,
UnitPrice money not null,
Discont real not null,



)
