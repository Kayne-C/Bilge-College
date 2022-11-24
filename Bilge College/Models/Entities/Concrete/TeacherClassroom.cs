using Bilge_College.Models.Entities.Abstract;

namespace Bilge_College.Models.Entities.Concrete
{
    public class TeacherClassroom : BaseEntity
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; }
    }
}
