using CA_ServicePattern.Services.CategoryServices;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ConsoleSpec.CategorySpecs
{
    public class CategoryConsoleSpec : ICategoryConsoleSpec
    {
        CategoryService categoryService = new CategoryService();


        public void AddCategory()
        {

            Category category = new Category();



            Console.WriteLine("Kategori Ad:");
            category.CategoryName = Console.ReadLine();

            categoryService.CreateCategory(category);

        }

        public void GetCategoriesConsoleApp()
        {
            foreach (Category item in categoryService.GetCategories(true))
            {
                Console.WriteLine(item.ID + " " + item.CategoryName);
            }
        }
    }
}
