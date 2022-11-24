using Bilge_College.Models.Entities.Abstract;

namespace Bilge_College.Models.Entities.Concrete
{
    public class SubSubjectClassroom : BaseEntity
    {
        public int SubSubjectId { get; set; }
        public SubSubject SubSubject { get; set; }
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
    }
}
