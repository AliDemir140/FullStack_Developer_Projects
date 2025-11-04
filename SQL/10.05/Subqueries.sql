--Normalizasyon
--Tablo
	--Kolon
	--Ýliþkilendirme

--T-SQL
	--DML ()
		--select:
		--insert:
		--update:
		--delete:
	--DDL ()
		--Create
		--Alter
		--Drop

		
	--DCL ()
		--Grant
		--Deny
		--Revoke

--Where: kriter uygulamak istediðimizde kullandýðýmýz komuttur
--Aggregate
--Group by
--Order by
--SubQuery

select * from Products

--ürün fiyatý 30'un üzerinde olan ürünleri listeleyin.
select * from Products where UnitPrice>30

--Aggregate
	--Fonkisyon: Dýþarýdan parametre alan ve bu parametre neticesinde bir sonuç döndüren eylemlerdir.
	--Count: 
	--SUM:
	--Max
	--Min

--ürünler tablosunda kaç adet satýr bulunmaktadýr.
select COUNT(*) from Products


--her kategoride kaç adet ürün bulunmaktadýr.

select COUNT(*),CategoryID from Products group by CategoryID order by 1 desc

--Order by:
	--asc: azdan çoka sýralama
	--desc: çoktan aza sýralama


--ürünleri fiyatlarýna göre çoktan aza doðru sýralayýnýz.
select MAX(UnitPrice) from Products order by UnitPrice desc

--AltSorgu (Subquery)

--bir ürünün hangi tedarikçiden alýndýðýný ürün adý ve tedarikçi þirket adýný listeyerek gösterin.
select ProductName,(select CompanyName from Suppliers where Suppliers.SupplierID=Products.SupplierID) as 'Tedarikç Þirket Ad' from Products-- sorunlu 

