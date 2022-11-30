namespace Bilge_College.Models.DTOs.StudentParent
{
    public class AddStudentParentDTO
    {
        public int StudentId { get; set; }
        public Entities.Concrete.Student Student { get; set; }
        public int ParentId { get; set; }
        public Entities.Concrete.Parent Parent { get; set; }
    }
}
