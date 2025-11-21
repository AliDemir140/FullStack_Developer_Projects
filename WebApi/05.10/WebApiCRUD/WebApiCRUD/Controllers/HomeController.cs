using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        //Route endpoint


        //public string Get()
        //{
        //    return "Hello World";
        //}

        [HttpGet]
        public IActionResult Get()
        {
            //eğer istek başarılı ise geriye 200 durum kodu dönsün.
            return Ok("İstek başarılı");
        }

       
    }
}
