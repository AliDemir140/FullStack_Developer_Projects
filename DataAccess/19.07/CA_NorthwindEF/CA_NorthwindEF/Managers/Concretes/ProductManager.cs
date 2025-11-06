using CA_NorthwindEF.Managers.Abstracts;
using CA_NorthwindEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_NorthwindEF.Managers.Concretes
{
    internal class ProductManager : IProductManager
    {

        NorthwindContext context = new NorthwindContext();

        public string CreateProduct(Product product)
        {
            try
            {
                context.Products.Add(product);
                context.SaveChanges();
                return "ürün kaydedildi!";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products;
        }
    }
}
