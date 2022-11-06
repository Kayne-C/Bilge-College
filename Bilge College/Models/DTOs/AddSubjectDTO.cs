using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;

namespace Bilge_College.Models.DTOs
{
    public class AddSubjectDTO
    {
        public string SubjectName { get; set; }
        public ICollection<SubSubject> SubSubjects { get; set; }
    }
}
