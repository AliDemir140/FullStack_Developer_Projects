--Group by
/*
	Group by komutu tablodaki ortak verilerin grý-uplanarak dönmesini saðlayan bir kokuttur. Group by komutunu kullanmadan önce gruplanacak olan alanlar (kolon) belirnelip daha sonra o alanlara göre bir select sorgusu gerçekleþtirilir.



*/

--Hangi kategoriden kaç adet ürün vardýr?
select CategoryID,COUNT(CategoryID) as 'Adet' from Products group by CategoryID

--Ülkelere göre çalýþan sayýsýný getirin.

select Country,COUNT(Country) from Employees group by Country

--Stokta hangi kategoriden toplam ne kadarlýk ürün vardýr?
--
select CategoryID,SUM(UnitPrice*UnitsInStock) from Products group by CategoryID

--Çalýþanlarýn almýþ olduðu sipariþ adet bilgisini çalýþan Id'lerine göre listeyin.

select EmployeeID,COUNT(*) as 'Sipariþ Adet' from Orders group by EmployeeID


