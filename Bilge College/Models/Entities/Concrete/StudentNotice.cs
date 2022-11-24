using Bilge_College.Models.Entities.Abstract;

namespace Bilge_College.Models.Entities.Concrete
{
    public class StudentNotice : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
