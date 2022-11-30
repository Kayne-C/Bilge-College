namespace Bilge_College.Models.DTOs.SubSubjectClassroom
{
    public class AddSubSubjectClassroomDTO
    {
        public int SubSubjectId { get; set; }
        public Entities.Concrete.SubSubject SubSubject { get; set; }
        public int ClassroomId { get; set; }
        public Entities.Concrete.Classroom Classroom { get; set; }
    }
}
