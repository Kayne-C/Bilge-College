using Bilge_College.Models.DTOs.Student.Review;
using Bilge_College.Models.Entities.Concrete;
using System.Collections.Generic;

namespace Bilge_College.Models.DTOs.SubSubject
{
    public class AddSubSubjectDTO
    {
        public string SubSubjectsName { get; set; }
        public int WeeklyClassTime { get; set; }
        public int SubSubjectCredit { get; set; }
        public Entities.Concrete.Grade Grade { get; set; }
        public int SubjectId { get; set; }
        public Entities.Concrete.Subject Subject { get; set; }
    }
}
