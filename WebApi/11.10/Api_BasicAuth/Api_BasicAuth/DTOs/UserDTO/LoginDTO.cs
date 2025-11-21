using System.ComponentModel.DataAnnotations;

namespace Api_BasicAuth.DTOs.UserDTO
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "Email boş geçilemez!")]
        [EmailAddress(ErrorMessage = "Geçersiz email adresi")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Şifre boş geçilemez!")]
        public string Password { get; set; }
    }
}
