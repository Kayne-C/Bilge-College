using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bilge_College.Models.DTOs
{
    public class AddInspectorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile UploadImage { get; set; }
        public string Duty { get; set; }
    }
}
