namespace Bilge_College.Models.DTOs.Teacher.TeacherClassroom
{
    public class AddTeacherClassroomDTO
    {
        public int TeacherId { get; set; }
        public Entities.Concrete.Teacher Teacher { get; set; }
        public int ClassroomId { get; set; }
        public Entities.Concrete.Classroom Classroom { get; set; }
    }
}
