using MVC_DependencyInjection.Models.Northwind;

namespace MVC_DependencyInjection.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {

        NorthwindContext _context = new NorthwindContext();

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
