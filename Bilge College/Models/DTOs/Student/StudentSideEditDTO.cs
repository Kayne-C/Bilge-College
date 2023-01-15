using Microsoft.AspNetCore.Http;

namespace Bilge_College.Models.DTOs.Student
{

        public class StudentSideEditDTO
        {
            public string Password { get; set; }
            public string Image { get; set; }
            public IFormFile UploadImage { get; set; } 
        }
}
