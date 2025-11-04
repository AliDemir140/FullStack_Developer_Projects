--Where (Kriter/filtreleme iþlemi)


--çalýþanlar tablosunu listeleyin.
select * from Employees

--EmployeeID'si 2 numaralý çalýþanýn bilgilerini listeleyin.
select * from Employees where EmployeeID=2

--chai isimli ürünün detaylarýný listeleyin.
select * from Products where ProductName='chai'

--10248 nolu sipariþin hangi ülkeye gönderildiðini listeleyin.

select ShipCountry from Orders where OrderID=10248

/*
	Operators
	=	atama operatörü
	>	büyüktür
	<	küçüktür
	>=	büyük/eþittir
	<=	küçük/eþittir
	!=	eþit deðildir
	<>	eþit deðildir.
	==	eþit eþittir.
*/

--Fiyatý 30'dan büyük ürünleri listeleyin.
select * from Products where UnitPrice>30

--Fiyatý 10 ile 30 arasýnda olan ürünleri listeleyin.
--42 Eyüp
--42 Kenan
--42 Sedat

select * from Products where UnitPrice>10 and UnitPrice<30
--Between

select * from Products where UnitPrice between 10 and 30 -- between deðerleri dahil eder.

--2 numaralý çalýþanýn aldýðý ve 2 numaralý nakliyecinin taþýdýðý sipariþleri listeleyin.
select * from Orders where EmployeeID=2 and ShipVia=2

--Alfki Id'sine ait müþterinin sipariþlerini, sipariþ numarasý, sipariþ tarihi ve sipariþ adres bilgileri ile birlikte listeleyin.
select OrderId,OrderDate,ShipAddress from Orders where CustomerID='alfki'

--Beverages isimli kategoriye ait ürünleri listeleyin.
select CategoryID from Categories where CategoryName='condiments'
select * from Products where CategoryID=2
