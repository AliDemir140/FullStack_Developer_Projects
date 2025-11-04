--Her müþterinin verdiði toplam sipariþ sayýsýný listeleyin. Çoktan aza sýralayýn
--Müþteri Þirket Ad    | Sipariþ Adet
select (select c.CompanyName from Customers c where c.CustomerID=o.CustomerID	),COUNT(*) from Orders o group by CustomerID order by 2 desc



--Her çalýþanýn aldýðý sipariþ sayýsý. Çoktan Aza sýralayýn.
--Çalýþan Ad Soyad   |   Sipariþ Adet
select (e.FirstName+' '+e.LastName) as 'Çalýþan' ,COUNT(*) as 'Sipariþ Sayýsý' from Orders o
 join Employees e on o.EmployeeID=e.EmployeeID
 group by (e.FirstName+' '+e.LastName) 
 order by 2 desc



--Her kategorideki ürünlerin ortalama fiyatlarýný listeleyin.
--Kategori Ad    |   Ortalama Fiyat


select (select c.CategoryName from Categories c where c.CategoryID=p.CategoryID),AVG(UnitPrice) from Products p
group by CategoryID 
order by 2 desc

--Hangi çalýþan hangi çalýþana baðlýdýr.
select calisan.FirstName as 'çalýþan',mudur.FirstName as 'müdür' from Employees calisan 
join Employees mudur on calisan.ReportsTo=mudur.EmployeeID


--Outer Join:
	--Left: left outer join sol tarafta kalan sütunun null olmayan ancak sað tarafta kalan sütunun null olan kayýtlarýný döndürür.
	--Right:right outer join sol tarafta kalan sütunun null olabilen ancak sað tarafta kalan sütunun null olmayan kayýtlarýný döndürür.


--Left Outer Join
--Hangi çalýþan hangi çalýþana baðlýdýr.
select calisan.FirstName as 'çalýþan',mudur.FirstName as 'müdür' from Employees calisan 
left outer join Employees mudur on calisan.ReportsTo=mudur.EmployeeID

select calisan.FirstName as 'çalýþan',mudur.FirstName as 'müdür' from Employees calisan 
right outer join Employees mudur on calisan.ReportsTo=mudur.EmployeeID


--Henüz kargoya verilmemiþ sipariþleri müþteri þirket adý ile birlikte listeleyin. 

select c.CompanyName,o.OrderDate,o.ShippedDate from Orders o 
inner join Customers c on c.CustomerID=o.CustomerID

where o.ShippedDate is null


--Bir sipariþin hangi çalýþan tarafýndan hangi müþteriye, hangi kategorideki üründen, hangi fiyattan ve kaç adet satýldýðýný listeleyin.
--Çalýþan Ad Soyad | Müþteri Þirket | Kategori Ad | Ürün Ad | Fiyat | Satýþ Adet

select FirstName+LastName as 'employee', Customers.CompanyName, Categories.CategoryName, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity from Employees
inner join Orders on Orders.EmployeeID=Employees.EmployeeID
inner join Customers on Customers.CustomerID=Orders.CustomerID
inner join [Order Details] on [Order Details].OrderID=Orders.OrderID
inner join Products on Products.ProductID=[Order Details].ProductID
inner join Categories on Categories.CategoryID=Products.CategoryID

--Hangi müþteriler henüz sipariþ vermemiþtir?
--15 dk
select c.CompanyName,o.OrderID from Customers c
left join Orders o on c.CustomerID=o.CustomerID
where o.OrderID is null


