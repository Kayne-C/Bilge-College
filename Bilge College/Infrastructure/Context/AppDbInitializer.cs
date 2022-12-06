//using Bilge_College.Models.Entities.Concrete;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace Bilge_College.Infrastructure.Context
//{
//    public class AppDbInitializer
//    {
//        public static void Seed(IApplicationBuilder applicationBuilder)
//        {
//            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
//            {
//                var context = serviceScope.ServiceProvider.GetService<BilgeDbContext>();
//                context.Database.EnsureCreated();

//                //context.Admins.AddRange(new List<Admin>()
//                //    {
//                //        new Admin()
//                //    {
//                //        Id = 21,
//                //        FirstName = "Chuck",
//                //        LastName = "LockWood",
//                //        Email = "chucklockwood@live.com",
//                //        Password = "12345678",
//                //        Image = "None",
//                //        Duty = "Administrator",
//                //        CreateDate = DateTime.Now,
//                //        UpdateDate = null,
//                //        DeleteDate = null,
//                //        Status = (Models.Entities.Abstract.Status)1,

//                //    },
//                //           new Admin()
//                //    {
//                //        Id = 22,
//                //        FirstName = "Sam",
//                //        LastName = "Winchester",
//                //        Email = "samwinchester@live.com",
//                //        Password = "12345678",
//                //        Image = "None",
//                //        Duty = "Co-Administrator",
//                //        CreateDate = DateTime.Now,
//                //        UpdateDate = null,
//                //        DeleteDate = null,
//                //        Status = (Models.Entities.Abstract.Status)1,
//                //    },
//                //           new Admin()
//                //    {
//                //        Id = 23,
//                //        FirstName = "Dean",
//                //        LastName = "Winchester",
//                //        Email = "deanwinchester@live.com",
//                //        Password = "12345678",
//                //        Image = "None",
//                //        Duty = "Co-Administrator",
//                //        CreateDate = DateTime.Now,
//                //        UpdateDate = null,
//                //        DeleteDate = null,
//                //        Status = (Models.Entities.Abstract.Status)1,
//                //    }
//                //    });

//                context.Classrooms.AddRange(new List<Classroom>()
//                    {
//                        new Classroom()
//                    {
//                        Id = 24,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Branch = 'A',
//                        Grade = (Grade)1,
//                    },
//                           new Classroom()
//                    {
//                        Id = 25,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Branch = 'B',
//                        Grade = (Grade)1,
//                    },
//                           new Classroom()
//                    {
//                        Id = 26,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Branch = 'C',
//                        Grade = (Grade)1,
//                    }
//                    });

//                context.Inspectors.AddRange(new List<Inspector>()
//                    {
//                        new Inspector()
//                    {
//                        Id = 27,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        FirstName = "Jack",
//                        LastName = "Sparrow",
//                        Email = "jacksparrow@live.com",
//                        Password = "12345678",
//                        Image = "None",
//                        Duty = "Pirate"
//                    },
//                            new Inspector()
//                    {
//                        Id = 28,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        FirstName = "Billy",
//                        LastName = "Little",
//                        Email = "billylittle@live.com",
//                        Password = "12345678",
//                        Image = "None",
//                        Duty = "Maniac"
//                    },
//                                new Inspector()
//                    {
//                        Id = 29,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        FirstName = "Buzz",
//                        LastName = "Lightyear",
//                        Email = "buzzlightyear@live.com",
//                        Password = "12345678",
//                        Image = "None",
//                        Duty = "Astronout"
//                    }
//                    });


//                context.Notes.AddRange(new List<Note>()
//                    {
//                        new Note()
//                    {
//                        Id = 30,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectId = 60,
//                        FirstExamScore = 60,
//                        SecondExamScore = 50,
//                        AvarageScore = 55,
//                        SchoolReportId = 45,
//                    },
//                              new Note()
//                    {
//                        Id = 31,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectId = 61,
//                        FirstExamScore = 70,
//                        SecondExamScore = 70,
//                        AvarageScore = 70,
//                        SchoolReportId = 46,

//                    },
//                              new Note()
//                    {
//                        Id = 32,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectId = 62,
//                        FirstExamScore = 80,
//                        SecondExamScore = 80,
//                        AvarageScore = 80,
//                        SchoolReportId = 47,
//                    }
//                    });


//                context.Parents.AddRange(new List<Parent>()
//                    {
//                        new Parent()
//                    {
//                        Id = 33,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        FirstName = "Ezio",
//                        LastName = "Auidotore",
//                        Email = "ezioauidotore@live.com",
//                        Password = "12345678",
//                        HomePhone = "123456789",
//                        HomeAddress = "NoAddress"
//                    } ,
//                         new Parent()
//                    {
//                        Id = 34,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        FirstName = "Altair",
//                        LastName = "Niobe",
//                        Email = "altairniobe@live.com",
//                        Password = "12345678",
//                        HomePhone = "1234567899",
//                        HomeAddress = "NoAddress"
//                    },
//                         new Parent()
//                    {
//                        Id = 35,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        FirstName = "Claire",
//                        LastName = "Redfield",
//                        Email = "ezioauidotore@live.com",
//                        Password = "12345678",
//                        HomePhone = "12345678900",
//                        HomeAddress = "NoAddress"
//                    }
//                    });

//                context.ParentMessages.AddRange(new List<ParentMessage>()
//                    {
//                        new ParentMessage()
//                    {
//                        Id = 36,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello",
//                        Context = "This is a test message",
//                        AdminId = 21,
//                        ParentId = 33,
//                    },

//                        new ParentMessage()
//                    {
//                        Id = 37,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello2",
//                        Context = "This is a test message2",
//                        AdminId = 22,
//                        ParentId = 34,
//                    },

//                        new ParentMessage()
//                    {
//                        Id = 38,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello3",
//                        Context = "This is a test message3",
//                        AdminId = 23,
//                        ParentId = 35,
//                    }
//                    });

//                context.ParentNotices.AddRange(new List<ParentNotice>()
//                    {
//                        new ParentNotice()
//                    {
//                        Id = 39,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello",
//                        Description = "This is a test notice",
//                        AdminId = 21,
//                        ParentId = 33,
//                    },

//                        new ParentNotice()
//                    {
//                        Id = 40,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello2",
//                        Description = "This is a test notice2",
//                        AdminId = 22,
//                        ParentId = 34,
//                    },

//                        new ParentNotice()
//                    {
//                        Id = 41,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello3",
//                        Description = "This is a test notice3",
//                        AdminId = 23,
//                        ParentId = 35,
//                    }
//                    });

//                context.Schools.AddRange(new List<School>()
//                    {
//                        new School()
//                    {
//                        Id = 42,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SchoolName = "Testschool",
//                        Level = (EducationLevel)1,
//                        Rate = 58,
//                        Capacity = 1222,
//                    },

//                        new School()
//                    {
//                        Id = 43,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SchoolName = "Testschool2",
//                        Level = (EducationLevel)1,
//                        Rate = 57,
//                        Capacity = 1244,
//                    },

//                        new School()
//                    {
//                        Id = 44,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SchoolName = "Testschool3",
//                        Level = (EducationLevel)2,
//                        Rate = 67,
//                        Capacity = 1253,

//                    }
//                    });

//                context.SchoolReports.AddRange(new List<SchoolReport>()
//                    {
//                        new SchoolReport()
//                    {
//                        Id = 45,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        StudentId = 48,
//                        Term = (Term)1,
//                        AbsentDay = 5,
//                    },

//                        new SchoolReport()
//                    {
//                        Id = 46,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        StudentId = 49,
//                        Term = (Term)1,
//                        AbsentDay = 7,
//                    },

//                        new SchoolReport()
//                    {
//                        Id = 47,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        StudentId = 50,
//                        Term = (Term)1,
//                        AbsentDay = 9,
//                    }
//                    });

//                context.Students.AddRange(new List<Student>()
//                    {
//                    new Student()
//                    {
//                        Id = 48,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        FirstName = "John",
//                        LastName = "Swear",
//                        BirthDate = new DateTime(1995,11,01),
//                        Gender = (Gender)1,
//                        Email = "johnswear@live.com",
//                        Password = "12345678",
//                        Image = "Empty",
//                        Grade = (Grade)1,
//                        ClassroomId = 24,
//                        SchoolId = 42,
//                        AvarageScore = 70,
//                        AttendanceStatus = (AStatus)1,
//                    },
//                        new Student()
//                    {
//                        Id = 49,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        FirstName = "John",
//                        LastName = "Swear",
//                        BirthDate = new DateTime(1995,11,01),
//                        Gender = (Gender)1,
//                        Email = "johnswear@live.com",
//                        Password = "12345678",
//                        Image = "Empty",
//                        Grade = (Grade)1,
//                        ClassroomId = 25,
//                        SchoolId = 43,
//                        AvarageScore = 85,
//                        AttendanceStatus = (AStatus)1,
//                    },
//                        new Student()
//                    {
//                        Id = 50,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        FirstName = "Klaus",
//                        LastName = "Ainzbell",
//                        BirthDate = new DateTime(1990,01,20),
//                        Gender = (Gender)1,
//                        Email = "klausainzbell@live.com",
//                        Password = "12345678",
//                        Image = "Empty",
//                        Grade = (Grade)1,
//                        ClassroomId = 26,
//                        SchoolId = 44,
//                        AvarageScore = 90,
//                        AttendanceStatus = (AStatus)1,
//                    }
//                    });

//                context.StudentMessages.AddRange(new List<StudentMessage>()
//                    {
//                    new StudentMessage()
//                    {
//                        Id = 51,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello",
//                        Context = "This is a test message",
//                        AdminId = 21,
//                        StudentId = 48,
//                    },
//                        new StudentMessage()
//                    {
//                        Id = 52,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello2",
//                        Context = "This is a test message2",
//                        AdminId = 22,
//                        StudentId = 49,
//                    },
//                        new StudentMessage()
//                    {
//                        Id = 53,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello3",
//                        Context = "This is a test message3",
//                        AdminId = 23,
//                        StudentId = 50,
//                    }
//                    });

//                context.StudentNotices.AddRange(new List<StudentNotice>()
//                    {
//                        new StudentNotice()
//                    {
//                        Id = 54,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello",
//                        Description = "This is a test notice",
//                        AdminId = 21,
//                        StudentId = 48,
//                    },

//                        new StudentNotice()
//                    {
//                        Id = 55,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello2",
//                        Description = "This is a test notice2",
//                        AdminId = 22,
//                        StudentId = 49,
//                    },

//                        new StudentNotice()
//                    {
//                        Id = 56,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        Title = "Hello3",
//                        Description = "This is a test notice3",
//                        AdminId = 23,
//                        StudentId = 50,
//                    }
//                    });

//                context.StudentParents.AddRange(new List<StudentParent>()
//                    {
//                        new StudentParent()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        StudentId = 48,
//                        ParentId = 33,
//                    },

//                        new StudentParent()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        StudentId = 49,
//                        ParentId = 34,
//                    },

//                        new StudentParent()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        StudentId = 50,
//                        ParentId = 35,
//                    }
//                    });


//                context.Subjects.AddRange(new List<Subject>()
//                    {
//                        new Subject()
//                    {
//                        Id = 57,
//                        SubjectName = "Subject1",
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                    },
//                           new Subject()
//                    {
//                        Id = 58,
//                        SubjectName = "Subject2",
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                    },
//                           new Subject()
//                    {
//                        Id = 59,
//                        SubjectName = "Subject3",
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                    }
//                    });


//                context.SubSubjects.AddRange(new List<SubSubject>()
//                    {
//                        new SubSubject()
//                    {
//                        Id = 60,   
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectsName = "SubSubject1",
//                        WeeklyClassTime = 5,
//                        SubSubjectCredit = 6,
//                        Grade = (Grade)1,
//                        SubjectId = 57,
//                    },
//                           new SubSubject()
//                    {
//                        Id = 61,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectsName = "SubSubject2",
//                        WeeklyClassTime = 4,
//                        SubSubjectCredit = 5,
//                        Grade = (Grade)1,
//                        SubjectId = 58,
//                    },
//                           new SubSubject()
//                    {
//                        Id = 62,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectsName = "SubSubject3",
//                        WeeklyClassTime = 3,
//                        SubSubjectCredit = 3,
//                        Grade = (Grade)1,
//                        SubjectId = 59,
//                    }
//                    });

//                context.SubSubjectClassrooms.AddRange(new List<SubSubjectClassroom>()
//                    {
//                        new SubSubjectClassroom()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectId = 60,
//                        ClassroomId = 24,
//                    },
//                           new SubSubjectClassroom()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectId = 61,
//                        ClassroomId = 25,
//                    },
//                           new SubSubjectClassroom()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectId = 62,
//                        ClassroomId = 26,
//                    }
//                    });

//                context.SubSubjectTeachers.AddRange(new List<SubSubjectTeacher>()
//                    {
//                        new SubSubjectTeacher()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectId = 60,
//                        TeacherId = 63,
//                    },
//                           new SubSubjectTeacher()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectId = 61,
//                        TeacherId = 64,
//                    },
//                           new SubSubjectTeacher()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        SubSubjectId = 62,
//                        TeacherId = 65,
//                    }
//                    });

//                context.Teachers.AddRange(new List<Teacher>()
//                    {
//                        new Teacher()
//                    {
//                        Id = 63,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,                  
//                        FirstName = "William",
//                        LastName = "Jones",
//                        Email = "williamjones@live.com",
//                        Password = "12345678",
//                        Image = "Empty",
//                        Branch = "Math",
//                        Duty = "None"
//                    },
//                           new Teacher()
//                    {
//                        Id = 64,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        FirstName = "Moira",
//                        LastName = "Barret",
//                        Email = "moirabarret@live.com",
//                        Password = "12345678",
//                        Image = "Empty",
//                        Branch = "Physics",
//                        Duty = "None"
//                    },
//                           new Teacher()
//                    {
//                        Id = 65,
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        FirstName = "Gabriel",
//                        LastName = "Logan",
//                        Email = "gabriellogan@live.com",
//                        Password = "12345678",
//                        Image = "Empty",
//                        Branch = "Biology",
//                        Duty = "None"
//                    }
//                    });

//                context.TeacherClassrooms.AddRange(new List<TeacherClassroom>()
//                    {
//                        new TeacherClassroom()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        ClassroomId = 24,
//                        TeacherId = 63,
//                    },
//                           new TeacherClassroom()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        ClassroomId = 25,
//                        TeacherId = 64,
//                    },
//                           new TeacherClassroom()
//                    {
//                        CreateDate = DateTime.Now,
//                        UpdateDate = null,
//                        DeleteDate = null,
//                        Status = (Models.Entities.Abstract.Status)1,
//                        ClassroomId = 26,
//                        TeacherId = 65,
//                    }
//                    });
//                context.SaveChanges();
//            }

//        }
//    }
//}
