using Bilge_College.Models.Entities.Abstract;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public class Classroom : BaseEntity
    {
        private int _cap = 25;
        public char Branch { get; set; }
        public Grade Grade{ get; set; }     
        public int Capacity {
            get { return _cap; }
            set { _cap = value; }
        }
        public ICollection<Student> Students { get; set; }
        public ICollection<TeacherClassroom> TeacherClassrooms { get; set; }
        public ICollection<SubSubjectClassroom> SubSubjectClassrooms { get; set; }
    }
}
