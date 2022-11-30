using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bilge_College.Models.DTOs.School
{
    public class UpdateSchoolDTO
    {
        public ICollection<Student> Students { get; set; }
    }
}
