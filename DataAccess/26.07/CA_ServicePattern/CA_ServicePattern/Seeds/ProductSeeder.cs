using CA_ServicePattern.Entities;

namespace CA_ServicePattern.Seeds
{
    internal class ProductSeeder
    {
       internal static List<Product> products = new List<Product>()
        {
            new Product{ID=1, ProductName="Test Product 1",CategoryId=1,SupplierId=1},
            new Product{ID=2, ProductName="Test Product 1", CategoryId=2,SupplierId=2},
            new Product{ID=3, ProductName="Test Product 1", CategoryId=3,SupplierId=1},

        };
    }
}
