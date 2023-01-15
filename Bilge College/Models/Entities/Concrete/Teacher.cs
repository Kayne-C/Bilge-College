using Bilge_College.Models.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public class Teacher : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public IFormFile UploadImage { get; set; }
        public string Branch { get; set; }
        public string Duty { get; set; }
        public ICollection<SubSubjectClassroom> SubSubjectClassrooms { get; set; }
        public ICollection<TeacherClassroom> TeacherClassrooms { get; set; }
        public ICollection<SubSubjectTeacher> SubSubjectTeachers { get; set; }

    }
}
