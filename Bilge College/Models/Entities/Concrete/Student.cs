using Bilge_College.Models.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bilge_College.Models.Entities.Concrete
{
    public enum Gender { Male = 1, Female}
    public enum Grade {IX=1, X, XI, XII }
    public enum AStatus { Continues = 1, Frozen, Graduated }
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile UploadImage { get; set; }
        public Grade Grade { get; set; }
        public int? ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
        public int? SchoolId { get; set; }
        public School School { get; set; }
        public int AvarageScore { get; set; }
        public AStatus AttendanceStatus { get; set; }
        public ICollection<Parent> Parents { get; set; }
        public ICollection<SchoolReport> SchoolReports { get; set; }
        public int AbsentDay { get; set; }

    }
}
