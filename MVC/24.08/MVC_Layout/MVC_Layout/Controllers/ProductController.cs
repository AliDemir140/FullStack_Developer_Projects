using Microsoft.AspNetCore.Mvc;
using MVC_Layout.Services;

namespace MVC_Layout.Controllers
{
    public class ProductController : Controller
    {

       ProductService _productService = new ProductService();
       // ProductFakeService _productService = new ProductFakeService();
        public IActionResult Index()
        {
            return View(_productService.GetProducts());
        }
    }
}
