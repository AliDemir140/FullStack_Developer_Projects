using MVC_Layout.Models.Northwind;

namespace MVC_Layout.Services
{
    public interface IProductService
    {
        //Listeleme Eylemi

        public List<Product> GetProducts();
    }
}
