namespace Bilge_College.Models.DTOs.SubSubjectTeacher
{
    public class AddSubSubjectTeacherDTO
    {
        public int SubSubjectId { get; set; }
        public Entities.Concrete.SubSubject SubSubject { get; set; }
        public int TeacherId { get; set; }
        public Entities.Concrete.Teacher Teacher { get; set; }
    }
}
