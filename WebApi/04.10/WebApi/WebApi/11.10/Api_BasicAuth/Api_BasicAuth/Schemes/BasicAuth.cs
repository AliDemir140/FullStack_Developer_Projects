using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace Api_BasicAuth.Schemes
{
    public class BasicAuth : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly UserManager<IdentityUser> _userManager;

        public BasicAuth(IOptionsMonitor<AuthenticationSchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock, UserManager<IdentityUser> userManager) : base(options, logger, encoder, clock)
        {
            _userManager = userManager;
        }

        protected async override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            //gelen isteğin Header bilgisine ulaşmamız gerekmektedir. Bu header içerisinde Authorization adında bir bilgi içeriyor mu?
            //Eğer içeriyorsa içinde bulunan username ve password bilgilerini yakalamamız gerkmektedir.

            var authRequest = Request.Headers.ContainsKey("Authorization");
            if (authRequest)
            {
                //Authorization bilgilerini ilk olarak byte kodunu dönüştürmemiz gerekiyor.
                var headerValue = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);//buradan bilgi base64 olarak teslim edilir. 
                //teslim edilen base64 şifreyi encoding (UTF-8) etmemiz gerekmektedir.

                var bytes = Convert.FromBase64String(headerValue.Parameter);


                var credentials = Encoding.UTF8.GetString(bytes);

                var array = credentials.Split(':');

                var username = array[0];
                var password = array[1];

                var userExits =await _userManager.FindByNameAsync(username);
                if (userExits != null)
                {
                    //şifre kontrolü
                    var passwordCheck =await _userManager.CheckPasswordAsync(userExits,password);
                    if (passwordCheck)
                    {
                        //token oluşturulacak.

                        //Claims: token kim için oluşturulacak?
                        var claims = new[] { new Claim(ClaimTypes.Name, username) }; 
                        
                        //Identity
                        var identity=new ClaimsIdentity(claims,Scheme.Name);

                        //principal
                        var pricipal=new ClaimsPrincipal(identity);

                        //ticket
                        var ticket = new AuthenticationTicket(pricipal, Scheme.Name);


                        return AuthenticateResult.Success(ticket);

                    }
                    else
                    {
                        return AuthenticateResult.Fail("şifreniz hatalı");
                    }

                }
                else
                {
                    return AuthenticateResult.Fail("kullanıcı bulunamadı");
                }


              

            }
            else
            {
                return AuthenticateResult.Fail("bilgiler boş olamaz!");
            }

        }
    }
}
