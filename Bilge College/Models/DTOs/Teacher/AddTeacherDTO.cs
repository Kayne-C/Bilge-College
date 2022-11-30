using Bilge_College.Models.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bilge_College.Models.DTOs.Teacher
{
    public class AddTeacherDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }   
        public string Branch { get; set; }
    }
}
