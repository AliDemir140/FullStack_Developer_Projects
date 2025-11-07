using MVC_Layout.Models.Northwind;

namespace MVC_Layout.Services
{
    public class ProductService : IProductService
    {

        NorthwindContext _context = new NorthwindContext();
        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }
    }
}
