--Tarih Fonksiyonlara

--Çalýþanlarýn doðum yýllarýný listeleyin.
select FirstName,LastName, YEAR(BirthDate) from Employees

select FirstName,LastName, Month(BirthDate) from Employees

select FirstName,LastName, Day(BirthDate) from Employees

--Çalýþanlarý yaþlarýný listeleyin. GetDate()
select FirstName+' '+LastName as 'Ad Soyad',YEAR(GETDATE())-YEAR(BirthDate) from Employees

--datediff => iki tarih arasýndaki farký verir.

select FirstName+' '+LastName as 'Ad Soyad',DATEDIFF(YEAR,BirthDate,GetDate()) from Employees


--1996 yýlý içinde alýnan sipariþleri listeleyin.
select * from Orders where YEAR(OrderDate)=1996

--Çalýþanlar bugüne kadar kaç gün çalýþmýþlardýr? yaþlarý ile birlikte listeleyin.
select 
FirstName+' '+LastName,
DATEDIFF(DAY,HireDate,GETDATE()) as 'Çalýþtýðýn Gün Sayý',
DATEDIFF(YEAR,BirthDate,GetDate()) as 'Yaþ' 
from Employees