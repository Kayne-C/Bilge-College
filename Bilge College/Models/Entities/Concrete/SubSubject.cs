using Bilge_College.Models.Entities.Abstract;
using System.Collections.Generic;

namespace Bilge_College.Models.Entities.Concrete
{
    public class SubSubject : BaseEntity
    {
        public string SubSubjectsName { get; set; }
        public int WeeklyClassTime { get; set; }
        public int SubSubjectCredit { get; set; }
        public Grade Grade { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public ICollection<SubSubjectClassroom> SubSubjectClassrooms { get; set; }
        public ICollection<SubSubjectTeacher> SubSubjectTeachers { get; set; }
        public ICollection<Note> Notes { get; set; }
    }
}
