using Api_JWT.DTOs.LoginDTOs;
using Api_JWT.Models.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Api_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly NorthwindContext _northwindContext;
        private readonly IConfiguration _configuration;

        public AuthController(NorthwindContext northwindContext, IConfiguration configuration)
        {
            _northwindContext = northwindContext;
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult Login([FromForm] LoginDTO loginDTO)
        {
            var user = _northwindContext.Employees
                .Where(x => x.FirstName == loginDTO.Firstname && x.LastName == loginDTO.Lastname)
                .FirstOrDefault(); //employee

            if (user != null)
            {
               var token= GetJwtToken(user);
                return Ok(token);
            }
            else
            {
                return BadRequest("kullanıcı bulunamadı!");
            }
        }

        //todo: Token oluşturan metot

         string GetJwtToken(Employee user)
        {
            //Claims
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.FirstName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier,user.EmployeeId.ToString())

            };


            //key
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));

            //crendentials
            var credientials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //lifetime
            var expires = DateTime.Now.AddDays(double.Parse(_configuration["JWT:LifeTime"]));

            //token => JWTSecurityToken
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"],
                audience: _configuration["JWT:Audience"],
                expires:expires,
                signingCredentials:credientials
               

                );

            var result=new JwtSecurityTokenHandler().WriteToken(token);
            return result;
        }


    }
}
