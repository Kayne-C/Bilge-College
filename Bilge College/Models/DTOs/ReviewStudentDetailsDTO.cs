using Bilge_College.Models.Entities.Concrete;
using System;

namespace Bilge_College.Models.DTOs
{
    public enum Gender { Male = 1, Female }
    public enum Grade { IX = 1, X, XI, XII }
    public enum AStatus { Continues = 1, Frozen, Graduated }
    public class ReviewStudentDetailsDTO
    {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public DateTime BirthDate { get; set; }
            public Gender Gender { get; set; }
            public Grade Grade { get; set; }
            public int? ClassroomId { get; set; }
            public char Branch { get; set; }
            public Classroom Classroom { get; set; }
            public int? SchoolId { get; set; }
            public School School { get; set; }
            public int AvarageScore { get; set; }
    }
}
