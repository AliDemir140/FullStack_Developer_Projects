using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Sepet.Models;
using MVC_Sepet.Models.CartModel;
using MVC_Sepet.Models.Northwind;
using MVC_Sepet.Utils;

namespace MVC_Sepet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindContext _context;

        public HomeController(ILogger<HomeController> logger, NorthwindContext context)
        {
            _logger = logger;
            _context = context;
        }


        public IActionResult Index()
        {

            var products = _context.Products.ToList();

            return View(products);
        }

        public IActionResult AddToCart(int id)
        {

            Product product = _context.Products.Find(id);

            if (product == null)
            {
                TempData["Error"] = "böyle bir ürün bulunamadı!";
                return RedirectToAction("Index");
            }
            else
            {
                //Session içerisinde bulunan AddItem için Cart nesnesi oluşturuldu.
                Cart cart = new Cart();
                cart.Id = product.ProductId;
                cart.ProductName=product.ProductName;
                cart.UnitPrice=product.UnitPrice;




                CartItem cartItem; //null   
                                   //server'da "sepet_session" isminde bir session oluşturulmuş mu? eğer oluşturulmuş ise GetProductFromJsom<T> metodu kullanıma alınarak cartItem doldurulacak.

                if (SessionHelper.GetProductFromJson<CartItem>(HttpContext.Session, "sepet_session")==null)
                {
                    //ilk kez ürün eklemek istediğinde tetiklenir.
                    cartItem=new CartItem();
                }
                else
                {
                    //session içerisinde sepet_session bulunmakta.
                    cartItem = SessionHelper.GetProductFromJson<CartItem>(HttpContext.Session, "sepet_session");
                }

                cartItem.AddItem(cart);

                //oluşturulan cartItem session'a eklenecek.
                SessionHelper.SetJsonProduct(HttpContext.Session, "sepet_session", cartItem);



                TempData["Success"] = "Ürün sepete eklendi!";

                return RedirectToAction("Index");
            }
        }

        public IActionResult MyCart()
        {

            var myCart = SessionHelper.GetProductFromJson<CartItem>(HttpContext.Session, "sepet_session");
            if (myCart == null)
            {
                TempData["Error"] = "sepetenizde ürün bulunmamaktadır!";
                return RedirectToAction("Index");
            }

            return View(myCart);
        }


        #region Tanımlı Action Metotlar
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}
