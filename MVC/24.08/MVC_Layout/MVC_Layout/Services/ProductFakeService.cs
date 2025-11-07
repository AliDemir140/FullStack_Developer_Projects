using MVC_Layout.Data;
using MVC_Layout.Models.Northwind;

namespace MVC_Layout.Services
{
    public class ProductFakeService : IProductService
    {

        
        public List<Product> GetProducts()
        {
            return ProductDummyData._products.ToList();
        }
    }
}
