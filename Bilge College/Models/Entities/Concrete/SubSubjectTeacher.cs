using Bilge_College.Models.Entities.Abstract;

namespace Bilge_College.Models.Entities.Concrete
{
    public class SubSubjectTeacher : BaseEntity
    {
        public int SubSubjectId { get; set; }
        public SubSubject SubSubject { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
