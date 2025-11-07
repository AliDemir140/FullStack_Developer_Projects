using Microsoft.AspNetCore.Mvc;
using MVC_DependencyInjection.Repositories;

namespace MVC_DependencyInjection.Controllers
{
    public class CategoryController : Controller
    {
        //Dependency Injection
        private ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }



        //FakeCategoryRepository _fakeCategoryRepository = new FakeCategoryRepository();

        //CategoryRepository _fakeCategoryRepository=new CategoryRepository();

        public IActionResult Index()
        {
            return View(_categoryRepository.GetCategories());
        }
    }
}
