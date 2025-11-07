using Microsoft.AspNetCore.Mvc;
using MVC_DataTransfer.Models;

namespace MVC_DataTransfer.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Product isimli modeli kullanarak birden fazla ürün oluşturun.
            List<Product> products = new List<Product>()
            {
                new Product{ID=1,ProductName="Model Chai", UnitPrice=15},
                new Product{ID=2,ProductName="Model Chang", UnitPrice=20},
                new Product{ID=3,ProductName="Model Ikura", UnitPrice=10},

            };

            //Categories
            List<Category> categories = new List<Category>()
            {
                new Category{ID=1,CategoryName="Beverages" },
                new Category{ID=2,CategoryName="Condiments" },
                new Category{ID=3,CategoryName="Desserts" },

            };


            //Suppliers
            List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier{ID=1,CompanyName="Alfki Company" },
                new Supplier{ID=2,CompanyName="Yılmaz Tic" },
                new Supplier{ID=3,CompanyName="Adam Company" },

            };


            //MVC Data Transfer:
            /*
              ViewData:  içerisinde küçük boyutlu veri saklayan ve bu verileri içerisinde doğrudan object olarak tutan MVC bileşenidir. Eğer ViewData içerisinde bulunan verileri doğrudan görüntülemek istiyorsak Cast işlemini uygulamamız gerekmektedir. 

              ViewBag: içerisinde küçük boyutlu veri saklayan ve bu verileri içerisinde doğrudan object olarak tutan MVC bileşenidir. Aralarındaki en büyük fark ViewData cast işlemini zorunlu hale getrir ViewBag isteğe bağlı olarak kullanılır.

                TempData: içerisinde object oalrak geçici veri saklar. Diğerlerinden (ViewData, ViewBag) farkı bir view içerisinde oluşturulur farklı view'lar içerisinde kullanıma alınabilinir. TempData içerisinde kompleks tip barındırır ancak okuyamaz. İçerisine string tipte bir değer atanırsa o değer doğrudan okunur.


             */


            ViewData["Categories"] = categories;
            ViewBag.Suppliers = suppliers;
            TempData["Message"] = "tempdata içerisinde örnek mesaj bulunmaktadır.";
            TempData.Keep(); //yukarıda tanımlanan tempdata içeriği bir sonraki istek ile birlikte tutulmaya devam edecek.


            return View(products);//main model
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}
