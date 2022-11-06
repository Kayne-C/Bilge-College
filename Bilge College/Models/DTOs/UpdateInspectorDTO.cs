using Microsoft.AspNetCore.Http;

namespace Bilge_College.Models.DTOs
{
    public class UpdateInspectorDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public IFormFile UploadImage { get; set; }
        public string Duty { get; set; }
    }
}
