using Bilge_College.Models.Entities.Abstract;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public class Absent : BaseEntity
    {
        public int AbsentDay { get; set; }
        public ICollection<StudentAbsent> StudentAbsents { get; set; }
    }
}
