using SingletonPattern.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern.Models.Data
{
    public class ProductData
    {
        public List<Product> Products = new List<Product>
        {
            new Product {ID=1,ProductName="A Product",UnitPrice=10},
            new Product {ID=2,ProductName="B Product",UnitPrice=15},
            new Product {ID=3,ProductName="C Product",UnitPrice=20},
        };
    }
}
