//EF
//Microsoft.EntityFrameworkCore.SqlServer
//Microsoft.EntityFrameworkCore.Tools
//DbFirst
//CodeFirst
//Context: veritabanı nesnesi
//Entities: tabloyu temsil eden nesneler
//Product
//Category
//Course
//Student
//Mapping: Tablolar arası ilişikiler
//One to One:
//One to many:
//Many to many:



using CA_ServicePattern.Context;
using CA_ServicePattern.Entities;
using CA_ServicePattern.Services.CategoryServices;

#region Intance ile verilerin atanması
//List<Category> categories = new List<Category>();

////Category 1
//Category category1 = new Category();
//category1.CategoryName = "Test Category 1";
//category1.ID = 1;

////Category 2
//Category category2 = new Category();
//category2.CategoryName = "Test Category 2";
//category2.ID = 2;



////Product 1
//Product product = new Product();
//product.ID = 1;
//product.ProductName = "Test Product 1";


////Product 2
//Product product2 = new Product();
//product2.ID = 2;
//product2.ProductName = "Test Product 2";

//category1.Products.Add(product);
//category2.Products.Add(product2);


//List<Product> products = new List<Product>();
//products.Add(product);
//products.Add(product2);

////
//foreach (Product p in products)
//{
//    Console.WriteLine(p.ProductName + " " + p.Category.CategoryName);
//}
#endregion

class Program
{
    public static void Main(string[] args)
    {
        //CodeFirstContext instance

        CategoryService categoryService = new CategoryService();
        CategoryFakeService fakeService = new CategoryFakeService();


        //var categoryList = categoryService.GetCategories(false);

        //foreach (var category in categoryList)
        //{
        //    Console.WriteLine(category.ID+" "+category.CategoryName);
        //}

        Category guncellenecekKategori = new Category
        {
            ID = 1,
            CategoryName = "Giyim"
        };

       // fakeService.UpdateCategory(guncellenecekKategori);
        categoryService.UpdateCategory(guncellenecekKategori);

    }
}