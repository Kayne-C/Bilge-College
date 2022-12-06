using Bilge_College.Models.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public class Admin : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public IFormFile UploadImage { get; set; }
        public string Duty { get; set; }    
        public ICollection<ParentNotice> ParentNotices { get; set; }
        public ICollection<StudentNotice> StudentNotices { get; set; }
        public ICollection<ParentMessage> ParentMessages { get; set; }
        public ICollection<StudentMessage> StudentMessages { get; set; }

       
    }

     

     
}
