using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_NorthwindDataTransfer.Models;
using MVC_NorthwindDataTransfer.Models.Northwind;

namespace MVC_NorthwindDataTransfer.Controllers
{
    public class HomeController : Controller
    {
        //Northwind Instance
        NorthwindContext _context = new NorthwindContext();


        public IActionResult Index()
        {
            //Index action'a istekte bulunulduğunda aşağıdaki veriler index sayfasında görüntülenecek.

            //Categories
            ViewBag.Categories = _context.Categories.ToList();
            //Supplier
            ViewBag.Suppliers=_context.Suppliers.ToList();

            ViewData["Title"] = "Anasayfa";

            return View(_context.Products.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
