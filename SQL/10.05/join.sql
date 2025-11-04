
--Join
/*
 Ýliþkili olan herhangi bir tabloyu farklý bir tabloya dahil etmek istediðimizde kullandýðýmýz komuttur.
	--Inner Join: iki tablo arasýndaki null olmayan kayýtlarý verir.
	--Outer Join: 
		--Left Join:
		--Right join
	--Cross Join:
*/

/*
	select 
	tablo1.kolon1
	tablo2.kolon1
	from
	tablo1
	inner join tablo2 on
	tablo1.kolonAd=tablo2.kolonAd
*/

--ürünleri kategori adý ile birlikte listeleyin.
select Products.ProductName,Categories.CategoryName from Products
inner join Categories on
Products.CategoryID=Categories.CategoryID

--Sipariþler tablosunu çalýþan bilgileri ile listeleyin.
--OrderId
--Firstname
--Lastname

select o.OrderID,e.FirstName,e.LastName from Orders o
inner join Employees e on e.EmployeeID=o.EmployeeID


--Sipariþ tablosunda hangi sipariþin (OrderId), hangi adrese (ShippedAddress), hangi kargo firmasý (Shippers/CompanyName) tarafýndan hangi taþýnma ücretinden (Freight) ve hangiye müþteriye (Customers/CompanyName) satýþ yapýldýðýný listeleyin.
select OrderID,ShipAddress,Freight,c.CompanyName, s.CompanyName from Orders o
inner join Customers c on
o.CustomerID=c.CustomerID
inner join Shippers s on
s.ShipperID=o.ShipVia

--Hangi personel hangi kategoriden toplamda kaç adet ürün satýþý yapmýþtýr?
--Firstname => Employees
--CategoryName => Categories
--TotalQuantity => Order Details


select e.FirstName, c.CategoryName,SUM(od.Quantity) from Employees e
inner join Orders o on e.EmployeeID=o.EmployeeID
inner join [Order Details] od on od.OrderID=o.OrderID
inner join Products p on p.ProductID=od.ProductID
inner join Categories c on c.CategoryID=p.CategoryID
group by e.FirstName,c.CategoryName

--Hangi ülkelere toplam ne kadarlýk satýþ yapýlmýþtýr?,

select top 3 ShipCountry, SUM(od.UnitPrice*od.Quantity) from Orders o
inner join [Order Details] od on o.OrderID=od.OrderID
group by ShipCountry
order by 2 desc

--Hangi personel hangi personele baðlýdýr? müdür çalýþan olarak listeleyin.
select calisan.FirstName as 'Çalýþan',mudur.FirstName as 'Müdür'  from Employees calisan
inner join Employees mudur on calisan.ReportsTo=mudur.EmployeeID
--Çalýþan  |   Müdür

