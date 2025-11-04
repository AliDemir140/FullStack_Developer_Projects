
--En yüksek fiyata sahip ürünün ürün adý, fiyat ve stok bilgisini listeleyin.

select ProductName,UnitPrice,UnitsInStock from Products where UnitPrice=(select MIN(UnitPrice) from Products)

