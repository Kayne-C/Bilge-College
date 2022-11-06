using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bilge_College.Models.DTOs
{
    public class AddStudentDTO
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Must to the type into a first name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Must to the type into a last name")]
        public string LastName { get; set; }
        [Display(Name = "Gender")]
        [Required(ErrorMessage = "Must to select a gender")]
        public Gender Gender { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        [Display(Name = "Avarage Score")]
        public int AvarageScore { get; set; }

    }
}
