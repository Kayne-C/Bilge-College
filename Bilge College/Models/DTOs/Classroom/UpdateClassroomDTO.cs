using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;

namespace Bilge_College.Models.DTOs.Classroom
{
    public class UpdateClassroomDTO
    {
        public int Capacity { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<SubSubject> SubSubjects { get; set; }

    }
}
