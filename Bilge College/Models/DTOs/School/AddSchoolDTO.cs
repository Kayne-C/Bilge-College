using Bilge_College.Models.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace Bilge_College.Models.DTOs.School
{
    public class AddSchoolDTO
    {
        public string SchoolName { get; set; }
        public EducationLevel Level { get; set; }
        public int Rate { get; set; }
        public int Capacity { get; set; }
    }
}
