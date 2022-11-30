using Microsoft.AspNetCore.Http;

namespace Bilge_College.Models.DTOs.Inspector
{
    public class UpdateInspectorDTO
    {   
        public string Email { get; set; }
        public string Password { get; set; }
        public IFormFile UploadImage { get; set; }
        public string Duty { get; set; }
    }
}
