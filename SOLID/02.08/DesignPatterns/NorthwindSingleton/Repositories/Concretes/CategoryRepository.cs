using NorthwindSingleton.Models;
using NorthwindSingleton.Repositories.Abstracts;
using NorthwindSingleton.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindSingleton.Repositories.Concretes
{
    internal class CategoryRepository : ICategoryRepository
    {
        private NrthwndSingleton singleton = new NrthwndSingleton();

        public void CreateCategory(Category category)
        {
            singleton.Context.Categories.Add(category);
            singleton.Context.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return singleton.Context.Categories.ToList();
        }
    }
}
