using Microsoft.AspNetCore.Mvc;

namespace MVC_Layout.Controllers
{
    public class HomeController : Controller
    {

        //Anasayfa
        public IActionResult Index()
        {
            return View();
        }

        //Hakkımızda
        public IActionResult About()
        {
            return View();
        }

        //İletişim
        public IActionResult Contact()
        {
            return View();
        }
    }
}
