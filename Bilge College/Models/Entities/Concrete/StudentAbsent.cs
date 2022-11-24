using Bilge_College.Models.Entities.Abstract;

namespace Bilge_College.Models.Entities.Concrete
{
    public class StudentAbsent : BaseEntity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int AbsentId { get; set; }
        public Absent Absent { get; set; }
    }
}
