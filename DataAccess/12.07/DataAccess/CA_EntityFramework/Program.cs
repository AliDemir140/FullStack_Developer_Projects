

using CA_EntityFramework.Models.Northwind;
//Microsoft.EntityFrameworkCore.SqlServer
//Microsoft.EntityFrameworkCore.Tools

/*

Scaffold-DbContext:  veritbanı yansıması için (ORM teknolojisinin kullanılması) kullanmamız gereken komuttur.

Projede Package Manager Console içerisinde tanımlanacak.


Scaffold-DbContext "Server=DESKTOP-J4PTH70;database=northwind;uid=sa;pwd=123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models/Northwind


 */


//Scaffold işlemi için aşağıdaki metoda ihtiyacımız var.
namespace CA_EntityFramework
{
    class Program
    {
        public static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();

            foreach (Category category in context.Categories)
            {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}









//EntityFramework

/*
    ORM: Object relational mapping
        veritabanında bulunan tabloları classlara, tablolar içerisinde bulunan kolonları property'lere çeviren teknolojidir.

DbFirst Approch=> Eğer elimizde mevcut bir veritabanı bulunuyorsa ve bu veritabanı'nın yansımasını (class) projeye dahil etmek istediğimizde kullanırız.

CodeFirst Approch=> Eğer elimizde mevcut bir veritabanı bulunmuyorsa ve class'ları tablo haline dönüştürerek ilerlemek istiyorsak o zaman codefirst yaklaşımını kullanmamız gerekmektedir.

ModelFirst Approch=> Bir model üzerinden vertiabanı nesneleri oluşturmak istediğimzide kullandığımız yaklaşım.

 */


