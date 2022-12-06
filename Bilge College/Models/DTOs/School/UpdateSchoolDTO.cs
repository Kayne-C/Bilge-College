using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bilge_College.Models.DTOs.School
{
    public class UpdateSchoolDTO
    {
        public ICollection<Entities.Concrete.Student> Students { get; set; }
    }
}
