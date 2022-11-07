using AutoMapper;
using Bilge_College.Models.DTOs;
using Bilge_College.Models.Entities.Concrete;

namespace Bilge_College.Models.AutoMapper
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Classroom, AddClassroomDTO>().ReverseMap();
            CreateMap<Classroom, UpdateClassroomDTO>().ReverseMap();

            CreateMap<Inspector, AddInspectorDTO>().ReverseMap();
            CreateMap<Inspector, UpdateInspectorDTO>().ReverseMap();

            CreateMap<Parent, AddParentDTO>().ReverseMap();
            CreateMap<Parent, UpdateParentDTO>().ReverseMap();

            CreateMap<Parent, AddParentDTO>().ReverseMap();
            CreateMap<Parent, UpdateParentDTO>().ReverseMap();
            
            CreateMap<School, AddSchoolDTO>().ReverseMap();
            CreateMap<School, UpdateSchoolDTO>().ReverseMap();

            CreateMap<SchoolReport, AddSchoolReportDTO>().ReverseMap();
            CreateMap<SchoolReport, UpdateSchoolReportDTO>().ReverseMap();

            CreateMap<Student, AddStudentDTO>().ReverseMap();
            CreateMap<Student, UpdateStudentDTO>().ReverseMap();

            CreateMap<Subject, AddSubjectDTO>().ReverseMap();
            CreateMap<Subject, UpdateSubjectDTO>().ReverseMap();

            CreateMap<SubSubject, AddSubSubjectDTO>().ReverseMap();
            CreateMap<SubSubject, UpdateSubSubjectDTO>().ReverseMap();

            CreateMap<Teacher, AddTeacherDTO>().ReverseMap();
            CreateMap<Teacher, UpdateTeacherDTO>().ReverseMap();

        }
    }
}
