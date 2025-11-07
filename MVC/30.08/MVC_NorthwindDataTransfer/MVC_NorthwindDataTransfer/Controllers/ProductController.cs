using Microsoft.AspNetCore.Mvc;
using MVC_NorthwindDataTransfer.Repositories;

namespace MVC_NorthwindDataTransfer.Controllers
{
    public class ProductController : Controller
    {

        //ProductRepository'den instance alınacak.
        ProductRepository _productRepository=new ProductRepository();
        public IActionResult Index()
        {
            return View(_productRepository.GetProducts());
        }
    }
}
