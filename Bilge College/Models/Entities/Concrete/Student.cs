using Bilge_College.Models.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public enum Gender { Erkek = 1, Kız}
    public enum Grade {IX=1, X, XI, XII }
    public enum AStatus { DevamEdiyor = 1, Donduruldu, Mezun }
    public class Student : BaseEntity
    {
        public string SchoolNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public IFormFile UploadImage { get; set; }
        public Grade Grade { get; set; }
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        public int AvarageScore { get; set; }  
        public AStatus AttendanceStatus { get; set; }
        public ICollection<StudentAbsent> StudentAbsents { get; set; }
        public ICollection<StudentMessage> StudentMessages { get; set; }
        public ICollection<StudentNotice> StudentNotice { get; set; }
        public ICollection<StudentParent> StudentParent { get; set; }
        public ICollection<SchoolReport> SchoolReports { get; set; }
        

    }
}
