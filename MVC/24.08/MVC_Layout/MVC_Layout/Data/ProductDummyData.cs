using MVC_Layout.Models.Northwind;

namespace MVC_Layout.Data
{
    public class ProductDummyData
    {
        public static List<Product> _products = new List<Product>
        {
            new Product{ProductId=1,ProductName="Ayakkabı",UnitPrice=15},
            new Product{ProductId=2,ProductName="Bilgisayar",UnitPrice=15},
            new Product{ProductId=3,ProductName="Telefon",UnitPrice=15},

        };
    }
}
