using Bilge_College.Models.Entities.Abstract;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public class Subject : BaseEntity
    {
        public string SubjectName { get; set; }
        public List<SubSubject> SubSubjects { get; set; }
    }
}
