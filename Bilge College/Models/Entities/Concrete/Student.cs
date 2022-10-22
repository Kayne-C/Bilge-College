using Bilge_College.Models.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public enum Gender { Male = 1, Female}
    public enum Grade { I=1, II, III, IV, V, VI, VII, VIII, IX, X, XI, XII }
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
        public IFormFile UploadImage { get; set; }
        public Grade Grade { get; set; }
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
        public int AvarageScore { get; set; }
        public AStatus AttendanceStatus { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Subject> SubjectsList { get; set; }
        public int AbsentDay { get; set; }
    }
}
