--Aggregate Fonksiyon (Toplam fonksiyonlar)
/*
	Aggreagte fonksiyonlar select ifadesi ile birlikte kullanýlan geriye tek satýr ve tek sütun sonuç döndüren yapýlardýr.
	1-Count() => satýr adedini tek satýr ve sütun olarak döndürür.
	2-SUM() => satýr deðerlerini toplamak istediðimzide kullandýðýmýz fonksiyondur.
	3-AVG()=> Ortalamayý verir.
	4-MAX()=> Maksimum deðeri verir.
	5-MIN()=> Minimum deðeri verir.


*/

--Kaç çeþit ürün bulunmaktadýr?
select COUNT(*),ProductName from Products

--Toplam ürün stok adedi nedir?
select SUM(UnitsInStock) as 'Toplam Stok' from Products

--Ürünlerin ortalama fiyatý nedir?
select AVG(UnitPrice) as 'Ortalama Fiyat' from Products

--Sipariþler içerisinde kargo ücreti en düþük ne kadardýr?
select MIN(Freight) from Orders

--Ürünler tablosundan en yüksek fiyat nedir ?
select MAX(UnitPrice) from Products

--Þuana kadar þirketimizin elde ettiði net gelir ne kadardýr?
select SUM(UnitPrice*Quantity*1-Discount) from [Order Details]
--Eyüp: 1354458,59
--Muhammet:1354337,55
--Kenan: 1265793,03
--Yiðit: 1200850,35
select SUM(UnitPrice*Quantity*1-Discount) from [Order Details]

select SUM(Freight) from Orders


