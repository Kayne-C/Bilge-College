using Bilge_College.Models.DTOs.Review;
using Bilge_College.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bilge_College.Models.DTOs.Student
{
    public class AddStudentDTO
    {
        public string SchoolNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public Entities.Concrete.School School { get; set; }
        public int AvarageScore { get; set; }
    }
}
