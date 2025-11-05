using NorthwindSingleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindSingleton.Repositories.Abstracts
{
    internal interface ICategoryRepository
    {
        List<Category> GetCategories();
        void CreateCategory(Category category);
    }
}
