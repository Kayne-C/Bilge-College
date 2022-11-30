using Microsoft.AspNetCore.Http;

namespace Bilge_College.Models.DTOs.Admin
{
    public class UpdateAdminDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public IFormFile UploadImage { get; set; }
        public string Duty { get; set; }
    }
}
