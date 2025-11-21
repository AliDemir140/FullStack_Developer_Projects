using WebApi.Models;

namespace WebApi.DummyData
{
    public class ProductData
    {

        static List<Product> products = new List<Product>(){
                new Product { Id=1,ProductName="chai",UnitPrice=10},
                new Product { Id=2,ProductName="chang",UnitPrice=15},

            };

        public static List<Product> GetProducts()
        {
            return products;
        }

        public static bool AddProduct(Product product)
        {
            try
            {
                products.Add(product);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool UpdateProduct(Product updated)
        {
           var product= products.Find(x=>x.Id==updated.Id);

            if (product != null)
            {
                product.ProductName = updated.ProductName;
                product.UnitPrice = updated.UnitPrice;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteProduct(int id)
        {
            var product = products.Find(x => x.Id == id);
            if (product != null)
            {
                products.Remove(product);
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
