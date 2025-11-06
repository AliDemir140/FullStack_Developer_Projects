//EF
//Veritabanında bulunan tabloları projes içerisinde class haline dönüştürmek ve bu tablo içerisinde bulunan kolonları da classlar içerisinde property olarak dahil etmek.

//Nuget Paketleri
//install-package
//Microsoft.EntityFrameworkCore.SQLServer
//Microsoft.EntityFrameworkCore.Tools
//Scaffold-Dbcontext: Veritabanı yansımasını projeye dahil eder.

//OOP Prensiplerine göre verilere işlemlerin uygulanması.


using CA_NorthwindEF.Managers;
using CA_NorthwindEF.Managers.Concretes;
using CA_NorthwindEF.Models;

namespace CA_NorthwindEF
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Model içerisinde bulunan nesnelere ait işlemleri farklı bir klasörde gerçekleştirmemiz gerekmektedir.

            //Category category = new Category
            //{
            //    CategoryName = "Test 5",
            //    Description = "Test 5"
            //};

            //Console'dan category bilgilerinin alınması.
            //CategoryManagerTest categoryManager = new CategoryManagerTest();

            //ConsoleManager consoleManager = new ConsoleManager();

           ConsoleManager consoleManager = new ConsoleManager();

            //Kategori Listeleme
            consoleManager.GetConsoleCategories();
            Console.WriteLine("*******");
            //Ürün Listeleme
            consoleManager.GetConsoleProductValues();

            
            

            Console.Read();
        }
    }
}


