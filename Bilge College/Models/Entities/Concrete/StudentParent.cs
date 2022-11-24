using Bilge_College.Models.Entities.Abstract;

namespace Bilge_College.Models.Entities.Concrete
{
    public class StudentParent : BaseEntity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int ParentId { get; set; }
        public Parent Parent { get; set; }  
    }
}
