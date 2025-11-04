--Order By
/*
	Order by komutu sorgu sonucu sıralama işlemleri için kullanılmaktadır. Order by komutu tablodaki bertilen kolonlara göre bize sırala olarak sonucu verir.

		--ascending => az'dan çok'a doğru.
		--descending=> çok'tan az'a doğru.

	Not: eğer sıralama işlemlerinde yukarıda tanımlı ifadelerden herhangi birini kullanamzsak varsayılan sıralama her zaman ascending (az'dan çok'a)'dir.


*/

--Ürünleri fiyatlarına göre az'dan çoka doğru sıralayın. Sorgu sonucun ürün adı ve fiyatını listeleyin.
select * from Products Order by UnitPrice asc

select * from Products Order by UnitPrice desc

--Ürün adlarını alfabetik olarak çoktan az'a sıralayın.
--ASCII kodu
select ProductName from Products Order by ProductName desc

--01.01.1997 ile 31.12.1997 tarihleri arasında alınan siparişlerin sipariş Id, sipariş tarihi ve ülke bilgisini tarih kolonuna göre çoktan az'a doğru sıralayın.

select OrderID,OrderDate,ShipCountry from Orders where YEAR(OrderDate)=1997 order by OrderDate desc


select OrderID,OrderDate,ShipCountry from Orders where OrderDate>='01.01.1997' and OrderDate<='12.31.1997' order by 2 desc

--1950,1955 ve 1960 yıllarında doğan çalışanları artan sıralama ile listeleyin. (Ad, soyad, doğum yılı)

select * from Employees where YEAR(BirthDate)=1950 or YEAR(BirthDate)=1955 or YEAR(BirthDate)=1960 order by BirthDate

select * from Employees where YEAR(BirthDate) in(1950,1955,1960) order by BirthDate