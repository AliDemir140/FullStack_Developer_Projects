using CA_CodeFirst.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CodeFirst.Models.Seeds
{
    internal class CategorySeedData
    {
        public static List<Category> seedCategories = new List<Category>()
        {

            new Category
            {
                ID=1,
                CategoryName="Teknoloji"
            },
            new Category
            {
                ID=2,
                CategoryName="Giyim"
            },
            new Category
            {
                ID=3,
                CategoryName="Gıda"
            },
        };
    }
}
