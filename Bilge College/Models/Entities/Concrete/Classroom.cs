using Bilge_College.Models.Entities.Abstract;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public class Classroom : BaseEntity
    {
        public char Branch { get; set; }
        public Grade Grade{ get; set; }
        public List<Student> Students { get; set; }
        public int Capacity { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
