using Microsoft.AspNetCore.Mvc;
using MVC_Intro.Models;
using MVC_Intro.Models.NorthwindModels;

namespace MVC_Intro.Controllers
{
    public class ProductController : Controller
    {


        //static List<Product> _productList = new List<Product>();

        NorthwindContext _context = new NorthwindContext();


        [HttpGet]
        //Ürün liste sayfası
        public IActionResult Index()
        {

            var products = _context.Products.ToList();

            //return View(_productList);
            return View(products);
        }


        [HttpGet]
        //Ürün ekleme sayfası
        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Create(string productName, decimal unitPrice, string categoryName)
        //{
        //    //parametre değerleri "Product" nesnesi tarafında kullanılacak.
        //    Product product = new Product()
        //    {
        //        ProductName = productName,
        //        UnitPrice = unitPrice,
        //        CategoryName = categoryName
        //    };
        //    _productList.Add(product);
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Create(Product product)
        //{
        //    //parametre değerleri "Product" nesnesi tarafında kullanılacak.
        //    product.ID=_productList.Count+1;
        //    _productList.Add(product);
        //    //return View();
        //    return RedirectToAction("Index");
        //}

        [HttpPost]
        public IActionResult Create(MVC_Intro.Models.NorthwindModels.Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
