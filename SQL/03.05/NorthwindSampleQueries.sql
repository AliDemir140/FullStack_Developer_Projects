--çalýþanlar tablosunu bütün kolonlarý ile birlikte listeleyin.
select * from Employees

--çalýþanlar tablosunu firstname, lastname, title ve reportsto kolon bilgileri ile listeleyin. Ancak kolon isimleri Türkçe olsun.

select FirstName as 'Ad', LastName as 'Soyad',Title as 'Ünvan',ReportsTo as 'MüdürId' from Employees

--Ürünler tablosunu bütün bilgileri ile listeleyin.
select * from Products

--Sipariþler tablosunda kaç sipariþ bulunuyor?

select * from Orders --830

select * from [Order Details]



--Müþteriler tablosunu müþteri þirket adý, temsilci adý ve telefon numarasý ile birlikte listeleyin.

select CompanyName,ContactName,Phone from Customers

--Nakliyeci (Kargo) firma ad ve telefon ile listeleyin.
select * from Shippers
