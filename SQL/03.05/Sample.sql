--burasý yorum satýrý

/*
burasý da yorum alaný
burasý
*/

--T-SQL (Transact Structured Query Languages)
--oluþturumuþ olduðumuz veritabaný içerisinde daha fazla anlamlý sorgular gerçekleþtirmek için kullanýlan bir sorgu dilidir. T-SQL içerisinde sorgu ve veri iþlemlerine ait 3 farklý kategori bulunmaktadýr.

--DML (Data Manipulation Language) - Veri ile ilgilenir.
--select: herhangi bir veriyi seçmek istediðimizde kullandýðýmýz komuttur.
--insert: veri ekleme
--update: veri güncelleme
--delete: veri silme

--DDL (Data Defination Language) - Nesne ile ilgilenir.
--create: nesne oluþturma. (database, table, column, SP, View)
--alter: nesne düzenleme
--drop: nesne kaldýrma

--DCL (Data Control Language)
--Grant: yetki verir.
--Deny: yetki engelleme
--Revoke: yetkiyi geri verme

--syntax: söz dizimi (sorgu oluþturma kuralý)


select 5 as Veri

select 10 as Numara
 
select 15 as 'Örnek Sayi'


select 20 as [Örnek Sayý]

select 50 Kolonad

select 'þiþe' as 'veri'

select 10+5 as 'Toplam Deðer'



--MovieTheater Select Sorgusu
--Movies 
--kayýtlý olan filmleri film adý ile birlikte listeleyin.


select MovieName from Movies
select * from Movies

select MovieName as 'Film Ad'  from Movies

--select kolonAd from tablo

--kayýtlý olan kategorileri kategori adý ile birlikte listeleyin.
select CategoryName from Categories

select * from Categories

--Hafta verilerini Hafta ad, baþlangýç tarih ve bitiþ tarih bilgileri ile listeleyin.
--Weeks
select 
Week as 'Hafta Ad', 
FirstDay as 'Baþlangýç', 
LastDay as 'Bitiþ' 
from Weeks

select FirstDay Baþlangýç, LastDay Bitiþ from Weeks

select Week as 'Hafta Ad', FirstDay, LastDay from Weeks

--T-Sql sorgu ekranýnda dilediðiniz kadar boþluk býrakabilirsiniz.
--T-Sql büyük küçük harf duyarlý deðildir!

select categoryname from categories