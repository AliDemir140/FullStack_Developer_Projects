using CA_ServicePattern.Entities;
using CA_ServicePattern.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ServicePattern.Services.CategoryServices
{
    internal class CategoryFakeService : ICategoryService
    {
        public void CreateCategory(Category category)
        {
            CategorySeeder.categoriesFakeData.Add(category);
        }

        public void DeleteCategory(int id)//100
        {
            var deletedCategory = CategorySeeder.categoriesFakeData.FirstOrDefault(x => x.ID == id);

            if (deletedCategory != null)
            {
                CategorySeeder.categoriesFakeData.Remove(deletedCategory);
            }
            else
            {
                Console.WriteLine("böyle bir kategori bulunamadı!");
            }
        }

        public List<Category> GetCategories(bool desc)
        {
            //eğer desc true gelirse kategoriler Id'e göre çoktan az'a sıralansın.
            //Değilse az'dan çok'a sıralansın.

            if (desc)
            {
                return CategorySeeder.categoriesFakeData.OrderByDescending(x => x.ID).ToList();
            }
            else
            {
                return CategorySeeder.categoriesFakeData.ToList();
            }

        }

        public void UpdateCategory(Category updated)
        {
            var existsCategory = CategorySeeder.categoriesFakeData.FirstOrDefault(x => x.ID == updated.ID);

            if (existsCategory != null)
            {
                existsCategory.CategoryName= updated.CategoryName;

            }
            else
            {
                Console.WriteLine("kategori bulunamadı!");
            }
        }
    }
}
