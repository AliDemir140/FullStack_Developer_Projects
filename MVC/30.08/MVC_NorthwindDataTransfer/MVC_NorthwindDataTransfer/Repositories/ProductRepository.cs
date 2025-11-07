using MVC_NorthwindDataTransfer.Models.Northwind;

namespace MVC_NorthwindDataTransfer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        NorthwindContext _context = new NorthwindContext();
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}
