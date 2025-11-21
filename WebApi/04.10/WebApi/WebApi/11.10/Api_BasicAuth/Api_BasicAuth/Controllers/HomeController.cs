using Api_BasicAuth.DTOs.UserDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Api_BasicAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public HomeController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        //Register
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDTO registerDTO)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    UserName = registerDTO.Username,
                    Email=registerDTO.Email,
                };

               var result=await _userManager.CreateAsync(user, registerDTO.Password);

                if (result.Succeeded)
                {
                    return Ok("Kullanıcı oluşturuldu");
                }
                else
                {
                    return BadRequest("hata meydana geldi!");
                }
            }
            else
            {
              //todo: Modelstate tarafından gelen hata mesajları da http response olarak dönmesi gerekmektedir.
                return BadRequest(ModelState);
            }



           
        }

        #region Bu işlem MVC için geçerli
        ////Login
        //[HttpPost("login")]
        //public async Task<IActionResult> Login(LoginDTO loginDTO)
        //{
        //    if (ModelState.IsValid)
        //    {

        //        //veritabanında kullanıcının bir karşılığı var mı?
        //        var user=await _userManager.FindByEmailAsync(loginDTO.Email);
        //        if (user == null)
        //        {
        //            return BadRequest("kullanıcı bulunamadı!");
        //        }
        //        else
        //        {
        //           var result=await _signInManager.PasswordSignInAsync(user, loginDTO.Password,false,false);
        //            if (result.Succeeded)
        //            {
        //                return Ok("kullanıcı giriş yaptı!");
        //            }
        //            else
        //            {
        //                return BadRequest("hata meydana geldi");
        //            }
        //        }

        //    }
        //    else
        //    {

        //        return BadRequest(ModelState);
        //    }

        //} 
        #endregion

       
    }
}
