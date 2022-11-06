using Bilge_College.Models.Entities.Abstract;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public class SchoolReport : BaseEntity
    {
        public ICollection<SubSubject> SubSubjects{ get; set; }
        public ICollection<Student> Students{ get; set; }
    }
}
