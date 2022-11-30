using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;

namespace Bilge_College.Models.DTOs.Subject
{
    public class AddSubjectDTO
    {
        public string SubjectName { get; set; }
        public ICollection<Entities.Concrete.SubSubject> SubSubjects { get; set; }
    }
}
