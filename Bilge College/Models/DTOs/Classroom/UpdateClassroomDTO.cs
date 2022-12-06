using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;

namespace Bilge_College.Models.DTOs.Classroom
{
    public class UpdateClassroomDTO
    {
        public int Capacity { get; set; }
        public ICollection<Entities.Concrete.Student> Students { get; set; }
        public ICollection<Entities.Concrete.Teacher> Teachers { get; set; }
        public ICollection<Entities.Concrete.SubSubject> SubSubjects { get; set; }

    }
}
