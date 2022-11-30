using System.ComponentModel.DataAnnotations;

namespace Bilge_College.Models.DTOs.Login
{
    public class LoginStudentDTO
    {
        [Required(ErrorMessage = "Lütfen E-Mail Adresinizi Giriniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz.")]
        public string Password { get; set; }
    }
}
