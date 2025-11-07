using MVC_NorthwindDataTransfer.Models.Northwind;

namespace MVC_NorthwindDataTransfer.Repositories
{
    public interface IProductRepository
    {

        List<Product> GetProducts();
    }
}
