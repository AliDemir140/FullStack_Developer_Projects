using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_ScopedTransientSingleton.Models;
using MVC_ScopedTransientSingleton.Services.Abstracts;

namespace MVC_ScopedTransientSingleton.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransientService _transientService1;
        private readonly ITransientService _transientService2;
        private readonly IScopedService _scopedService2;
        private readonly ISingletonService _singletonService1;
        private readonly ISingletonService _singletonService2;
        private readonly IScopedService _scopedService1;

        public HomeController(
            ITransientService transientService1, 
            ITransientService transientService2,
            IScopedService scopedService1,
            IScopedService scopedService2,
            ISingletonService singletonService1,
            ISingletonService singletonService2
            )
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopedService2 = scopedService2;
            _singletonService1 = singletonService1;
            _singletonService2 = singletonService2;
            _scopedService1 = scopedService1;
        }

        public IActionResult Index()
        {
            //ViewBag.Transient1
            ViewBag.Transient1=_transientService1.GetGuid(); //benzersiz bir guid
            //ViewBag.Transient2
            ViewBag.Transient2=_transientService2.GetGuid(); //benzersiz bir guid

            //ViewBag.Scoped1
            ViewBag.Scoped1=_scopedService1.GetGuid();

            //ViewBag.Scoped2
            ViewBag.Scoped2 = _scopedService2.GetGuid();

            //ViewBag.Singleton1
            ViewBag.Singleton1=_singletonService1.GetGuid();
            //ViewBag.Singleton2
            ViewBag.Singleton2 = _singletonService2.GetGuid();



            return View();
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
