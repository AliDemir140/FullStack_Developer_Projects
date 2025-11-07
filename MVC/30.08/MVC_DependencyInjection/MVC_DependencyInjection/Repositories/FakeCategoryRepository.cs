using MVC_DependencyInjection.Models.Northwind;

namespace MVC_DependencyInjection.Repositories
{
    public class FakeCategoryRepository : ICategoryRepository
    {


        List<Category> _categories = new List<Category>
        {
            new Category{CategoryId=1,CategoryName="Fake Category 1", Description="Fake Category 1 Description"},
             new Category{CategoryId=2,CategoryName="Fake Category 2", Description="Fake Category 2 Description"},
              new Category{CategoryId=3,CategoryName="Fake Category 3", Description="Fake Category 3 Description"},
        };




        public List<Category> GetCategories()
        {
            return _categories;
        }
    }
}
