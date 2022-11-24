using Bilge_College.Models.Entities.Abstract;
using Microsoft.AspNetCore.Http;

namespace Bilge_College.Models.Entities.Concrete
{
    public class Inspector : BaseEntity
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

 