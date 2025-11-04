--SubQuery
/*
	iç içe birden fazla sorgular yazmak için kullanmýþ olduðumuz yöntemdir. Alt sorgularda her zaman en içten dýþarýya doðru tek sonuç döndürmek kaydýyla oluþturmamýz gerekir.

*/

--Fiyatý ortalama fiyatýn altýnda kalan ürünleri listeleyin.

select * from Products where UnitPrice<(select AVG(UnitPrice) from Products)

--ürünler tablosundan ürün adý, fiyatý ve kategori adý ile birlikte listeleyin.
select ProductID, ProductName,UnitPrice,(select CategoryName from Categories where Categories.CategoryID=Products.CategoryID) from Products



select ProductName,UnitPrice,(select CompanyName from Suppliers where Suppliers.SupplierID=Products.SupplierID) as 'Tedarikçi Þirket',(select CategoryName from Categories where Categories.CategoryID=Products.CategoryID) as 'Kategori' from Products

--Sipariþ detay tablosundan  ürün adlarý ile birlikte listeyin.


select OrderId,(select ProductName from Products where Products.ProductID=[Order Details].ProductID) as 'Ürün Ad',UnitPrice,Quantity from [Order Details]



 