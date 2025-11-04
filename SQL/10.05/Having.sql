--Aggregate fonksiyonlar sadece select ile from arasýnda kullanýlýr.

--Having
	--Eðer sorgu sonu dönen cevapta bir aggregate fonksiyonuna baðlý kriter iþlemi gerçekleþtirmek için kullanýlýr.


--Her bir sipariþteki toplam ürün sayýsý 100'den az olanlarý listeleyin.

select * from Orders
select OrderID,SUM(Quantity),(select CustomerID from Orders where Orders.OrderID=[Order Details].OrderID) as 'Müþteri ID'  from [Order Details] group by OrderID having SUM(Quantity)<100

--Elde edilen net gelir 2500 ile 3500 arasýnda olan sipariþleri çoktan az'a doðru listeleyin.
select OrderID,SUM(Quantity*UnitPrice) from [Order Details] group by OrderID having SUM(Quantity*UnitPrice) between 2500 and 3500 order by 2 desc

select OrderID,SUM(Quantity*UnitPrice) as 'Toplam Gelir' from [Order Details] group by OrderID having SUM(Quantity*UnitPrice) between 2500 and 3500 order by [Toplam Gelir] desc