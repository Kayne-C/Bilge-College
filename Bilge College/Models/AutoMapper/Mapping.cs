using AutoMapper;
using Bilge_College.Models.DTOs.Admin;
using Bilge_College.Models.DTOs.Classroom;
using Bilge_College.Models.DTOs.Inspector;
using Bilge_College.Models.DTOs.Login;
using Bilge_College.Models.DTOs.Parent;
using Bilge_College.Models.DTOs.ParentMessage;
using Bilge_College.Models.DTOs.ParentNotice;
using Bilge_College.Models.DTOs.Review;
using Bilge_College.Models.DTOs.School;
using Bilge_College.Models.DTOs.SchoolReport;
using Bilge_College.Models.DTOs.Student;
using Bilge_College.Models.DTOs.Student.StudentMessage;
using Bilge_College.Models.DTOs.Student.StudentNotice;
using Bilge_College.Models.DTOs.StudentParent;
using Bilge_College.Models.DTOs.Subject;
using Bilge_College.Models.DTOs.SubSubject;
using Bilge_College.Models.DTOs.SubSubjectClassroom;
using Bilge_College.Models.DTOs.SubSubjectTeacher;
using Bilge_College.Models.DTOs.Teacher;
using Bilge_College.Models.DTOs.Teacher.TeacherClassroom;
using Bilge_College.Models.Entities.Concrete;

namespace Bilge_College.Models.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Admin, AddAdminDTO>().ReverseMap();
            CreateMap<Admin, UpdateAdminDTO>().ReverseMap();

            CreateMap<Classroom, AddClassroomDTO>().ReverseMap();
            CreateMap<Classroom, UpdateClassroomDTO>().ReverseMap();

            CreateMap<Inspector, AddInspectorDTO>().ReverseMap();
            CreateMap<Inspector, UpdateInspectorDTO>().ReverseMap();

            CreateMap<Parent, AddParentDTO>().ReverseMap();
            CreateMap<Parent, UpdateParentDTO>().ReverseMap();

            CreateMap<Parent, AddParentDTO>().ReverseMap();
            CreateMap<Parent, UpdateParentDTO>().ReverseMap();
            CreateMap<ParentMessage, AddParentMessageDTO>().ReverseMap();
            CreateMap<ParentNotice, AddParentNoticeDTO>().ReverseMap();

            CreateMap<School, AddSchoolDTO>().ReverseMap();
            CreateMap<School, UpdateSchoolDTO>().ReverseMap();

            CreateMap<SchoolReport, AddSchoolReportDTO>().ReverseMap();
            CreateMap<SchoolReport, UpdateSchoolReportDTO>().ReverseMap();

            CreateMap<Student, AddStudentDTO>().ReverseMap();
            CreateMap<Student, UpdateStudentDTO>().ReverseMap();
            CreateMap<Student, LoginStudentDTO>().ReverseMap();
            CreateMap<Student, ReviewStudentDetailsDTO>().ReverseMap();
            CreateMap<StudentMessage, AddStudentMessageDTO>().ReverseMap();
            CreateMap<StudentNotice, AddStudentNoticeDTO>().ReverseMap();

            CreateMap<StudentParent, AddStudentParentDTO>().ReverseMap();

            CreateMap<Subject, AddSubjectDTO>().ReverseMap();

            CreateMap<SubSubject, AddSubSubjectDTO>().ReverseMap();
            CreateMap<SubSubject, UpdateSubSubjectDTO>().ReverseMap();
            CreateMap<SubSubjectClassroom, AddSubSubjectClassroomDTO>().ReverseMap();
            CreateMap<SubSubjectTeacher, AddSubSubjectTeacherDTO>().ReverseMap();

            CreateMap<Teacher, AddTeacherDTO>().ReverseMap();
            CreateMap<Teacher, UpdateTeacherDTO>().ReverseMap();
            CreateMap<TeacherClassroom, AddTeacherClassroomDTO>().ReverseMap();


        }
    }
}
