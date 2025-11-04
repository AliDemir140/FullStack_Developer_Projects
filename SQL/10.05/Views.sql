--Bir sipariþin hangi çalýþan tarafýndan hangi müþteriye, hangi kategorideki üründen, hangi fiyattan ve kaç adet satýldýðýný listeleyin.
--Çalýþan Ad Soyad | Müþteri Þirket | Kategori Ad | Ürün Ad | Fiyat | Satýþ Adet

select FirstName+LastName as 'employee', Customers.CompanyName, Categories.CategoryName, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity from Employees
inner join Orders on Orders.EmployeeID=Employees.EmployeeID
inner join Customers on Customers.CustomerID=Orders.CustomerID
inner join [Order Details] on [Order Details].OrderID=Orders.OrderID
inner join Products on Products.ProductID=[Order Details].ProductID
inner join Categories on Categories.CategoryID=Products.CategoryID 




--Views (dbo)
--bir sorguyu bir çatý altýnda saklamak için kullandýðýmýz veritabaný nesnesidir.

 --DDL: Veritabaný nesnelerine uygulanan eylemlerdir.
	--Create
	--Alter
	--Drop

go


--Create View
create view SatisRaporu
as
select FirstName+LastName as 'employee', Customers.CompanyName, Categories.CategoryName, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity from Employees
inner join Orders on Orders.EmployeeID=Employees.EmployeeID
inner join Customers on Customers.CustomerID=Orders.CustomerID
inner join [Order Details] on [Order Details].OrderID=Orders.OrderID
inner join Products on Products.ProductID=[Order Details].ProductID
inner join Categories on Categories.CategoryID=Products.CategoryID

--Using View
select * from SatisRaporu where employee='StevenBuchanan'

--Alter

alter view SatisRaporu
as
select FirstName as 'Ad',LastName as 'Soyad', Customers.CompanyName, Categories.CategoryName, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity from Employees
inner join Orders on Orders.EmployeeID=Employees.EmployeeID
inner join Customers on Customers.CustomerID=Orders.CustomerID
inner join [Order Details] on [Order Details].OrderID=Orders.OrderID
inner join Products on Products.ProductID=[Order Details].ProductID
inner join Categories on Categories.CategoryID=Products.CategoryID

select * from SatisRaporu where Ad='nancy'


--Encryption

select * from SatisRaporu

create view SatisRaporu
with encryption
as
select FirstName as 'Ad',LastName as 'Soyad', Customers.CompanyName, Categories.CategoryName, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity from Employees
inner join Orders on Orders.EmployeeID=Employees.EmployeeID
inner join Customers on Customers.CustomerID=Orders.CustomerID
inner join [Order Details] on [Order Details].OrderID=Orders.OrderID
inner join Products on Products.ProductID=[Order Details].ProductID
inner join Categories on Categories.CategoryID=Products.CategoryID

--Drop
drop view SatisRaporu