--DML
	--select
	--insert
	--update
	--delete

--Categories
insert Categories (CategoryName,Description) values ('Teknoloji','telefon, tablet, bilgisayar')
insert Categories values ('yazlýk kýþlýk ürünler','Oyuncak'),('parfüm faln  filan','Kozmetik')

update Categories set CategoryName='Kozmetik' where CategoryId=3


select * from Categories
delete from Categories where CategoryId=10
	

--Products

--Suppliers

--Customers

--Employees

--Orders

--Order Details

