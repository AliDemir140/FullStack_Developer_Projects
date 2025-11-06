
using CA_ServicePattern.Services.CategoryServices;
using DAL.Entities;
using Presentation.ConsoleSpec.CategorySpecs;

class Program
{
    public static void Main(string[] args)
    {
        //CodeFirstContext instance

        
        CategoryConsoleSpec categoryConsoleSpec = new CategoryConsoleSpec();

        categoryConsoleSpec.GetCategoriesConsoleApp();
        categoryConsoleSpec.AddCategory();
        Console.WriteLine("yeni eklenen kategori");
        categoryConsoleSpec.GetCategoriesConsoleApp();

    }
}