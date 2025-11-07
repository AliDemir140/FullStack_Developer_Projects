using MVC_DependencyInjection.Models.Northwind;

namespace MVC_DependencyInjection.Repositories
{
    public interface ICategoryRepository
    {

        //Category List
        List<Category> GetCategories();
    }
}
