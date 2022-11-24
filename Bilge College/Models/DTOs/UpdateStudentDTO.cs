using Bilge_College.Models.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Bilge_College.Models.DTOs
{
    public class UpdateStudentDTO
    {
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Display(Name = "Profile Photo")]
        public string Image { get; set; }

        public IFormFile UploadImage { get; set; }
    }
}
