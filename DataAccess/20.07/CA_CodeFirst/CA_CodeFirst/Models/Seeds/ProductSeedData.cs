using CA_CodeFirst.Models.Entities;

namespace CA_CodeFirst.Models.Seeds
{
    public class ProductSeedData
    {
        public static List<Product> seedProductData = new List<Product>
        {
            new Product
            {
                ID= 1,
                ProductName="IPhone 16 Pro Max",
                UnitPrice=100000,
                CategoryId=1
            },
            new Product
            {
                ID= 2,
                ProductName="Gömlek",
                UnitPrice=500,
                CategoryId=2
            },
            new Product
            {
                ID= 3,
                ProductName="Buğday Ekmek",
                UnitPrice=50,
                CategoryId=3
            },
        };
    }
}
