using System;

namespace Bilge_College.Models.DTOs.Student
{
    public class AddStudentDTO
    {
        public string SchoolNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Entities.Concrete.Gender Gender { get; set; }
        public int SchoolId { get; set; }
        public Entities.Concrete.School School { get; set; }
        public int AvarageScore { get; set; }
    }
}
