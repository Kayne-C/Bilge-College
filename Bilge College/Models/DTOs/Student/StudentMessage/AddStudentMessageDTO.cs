namespace Bilge_College.Models.DTOs.Student.StudentMessage
{
    public class AddStudentMessageDTO
    {
        public string Title { get; set; }
        public string Context { get; set; }
        public int AdminId { get; set; }
        public Entities.Concrete.Admin Admin { get; set; }
        public int StudentId { get; set; }
        public Entities.Concrete.Student Student { get; set; }
    }
}
