using Bilge_College.Models.Entities.Concrete;
using System.ComponentModel.DataAnnotations;

namespace Bilge_College.Models.DTOs
{
    public class AddSchoolDTO
    {
        [MinLength(7, ErrorMessage = "Minimum Lenght is 7")]
        [Required(ErrorMessage = "Must to the type into a School Name")]
        public string SchoolName { get; set; }
        [Required(ErrorMessage = "Must to select a Education Degree")]
        public EducationLevel Level { get; set; }
        public int? Rate { get; set; }
        public int? Capacity { get; set; }
    }
}
