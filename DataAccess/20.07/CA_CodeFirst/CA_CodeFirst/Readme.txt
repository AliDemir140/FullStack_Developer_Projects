

-- İhtiyacımız olan kütüphaneler
	- Microsoft.EntityFrameworkCore.SqlServer
	- Microsoft.EntityFrameworkCore.Tools

-- Entities isminde bir adet klasör oluşturarak içerisinde AppUser isminde bir class tanımladık.
	- Entities klasörü içerisinde bulunan class veritabnaında tablo haline gelecek classdır.
--context isminde bir adet klasör tanımlandı. Bu klasörün nihai amacı dışarıda bulunan class ya da classları veritabanında tablo haline dönüştürmesi.
		-- context kesinlikle Dbcontext isimli class'dan miras almalıdır (Microsoft.EntityFrameworkCore). 
		--Context içerisinde bulunan DbSet<> generic sınıfı dışarıdan alınan class'ı tablo haline döüştürecek bir sınıftır.
		--DbContext sınıfında bir takım ezilibilinir metotlar bulunmaktadır. Bu metotlardan ilki 
			OnConfiguring(), ikincisi ise OnModelCreating(), metotlarıdır.
			--OnConfiguring(): bu metot veritbanı için bağlantı cümlesini bünyesinde barındırır. ne zaman biz Package console içerisinde update-database komutu gerçekeltirirsek bu metot içindeki connectionString tarafına işlemler gönderilir.
--Migration
	--Yukarıdaki işlemleri tanımladıktan sonra "Microsoft.EntityFrameworkCore.Tools" kütüphanesi ile birlikte Package Maanger Console'da aşağıdaki komutlar tanımlandı.
		-- add-migration: Entity olarak tanımladığımız classları tablo formatına dönüştürmek için kullandığımız komuttur. Projenin root'unda (çatısında) migrations isminde bir klasör tanımlanır.
		-- update-database: daha önce yapılandırılmış olunan migration (tablo haline gelecek paket) veritabanına iletirlir.
			