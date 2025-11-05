using NorthwindSingleton.Models;
using NorthwindSingleton.Repositories.Concretes;
using NorthwindSingleton.Singleton;

class Program
{
    public static void Main(string[] args)
    {
        //NrthwndSingleton singleton = new NrthwndSingleton();

        //foreach (Product arg in singleton.Context.Products)
        //{
        //    Console.WriteLine(arg.ProductName);
        //}

        //foreach (Product arg in singleton.Context.Products)
        //{
        //    Console.WriteLine(arg.ProductName);
        //}

        CategoryRepository categoryRepository = new CategoryRepository();
        categoryRepository.GetCategories();
    }
}