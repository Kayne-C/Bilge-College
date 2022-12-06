using Bilge_College.Models.DTOs.Student.Review;
using Bilge_College.Models.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bilge_College.Models.DTOs.Student
{
    public class UpdateStudentDTO
    {
        public string Password { get; set; }
        public string Image { get; set; }
        public IFormFile UploadImage { get; set; }
        public Entities.Concrete.Grade Grade { get; set; }
        public int ClassroomId { get; set; }
        public Entities.Concrete.Classroom Classroom { get; set; }
        public int SchoolId { get; set; }
        public Entities.Concrete.School School { get; set; }
        public int AvarageScore { get; set; }
        public Entities.Concrete.AStatus AttendanceStatus { get; set; }
        public ICollection<Entities.Concrete.StudentMessage> StudentMessages { get; set; }
        public ICollection<Entities.Concrete.StudentNotice> StudentNotices { get; set; }
        public ICollection<Entities.Concrete.StudentParent> StudentParent { get; set; }
        public ICollection<Entities.Concrete.SchoolReport> SchoolReports { get; set; }
    }
}
