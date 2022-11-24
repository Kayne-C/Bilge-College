using Bilge_College.Models.Entities.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bilge_College.Infrastructure.Context
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<BilgeDbContext>();
                context.Database.EnsureCreated();

                
                    context.Classrooms.AddRange(new List<Classroom>()
                    { 
                        new Classroom()
                    {
                        Id = 21,
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        Branch = 'A',
                        Grade = (Grade)1,
                        Capacity = 30,                       
                        
                      
                    },
                           new Classroom()
                    {
                        Id = 22,
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        Branch = 'B',
                        Grade = (Grade)1,
                        Capacity = 30,


                    }

                    });
               
               
                    context.Inspectors.AddRange(new List<Inspector>()
                    {
                        new Inspector()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        FirstName = "Test",
                        LastName = "Making",
                        Email = "test@live.cym",
                        Password = "12345678",
                        Image = "test",
                        Duty = "test"
                    },
                          new Inspector()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        FirstName = "Test2",
                        LastName = "Making2",
                        Email = "test@live.cym",
                        Password = "12345678",
                        Image = "test",
                        Duty = "test"
                    }
                    });
                
               
                    context.Notices.AddRange(new List<Notice>()
                    {
                        new Notice()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        TeacherId = 21,
                        Title = "TestTitle",
                        Description = "Some words for testing",
                        
                    },
                           new Notice()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        Title = "TestTitle2",
                        TeacherId = 22,
                        Description = "Some words for testing222",
                        
                    }
                    });
                
                
                    context.Parents.AddRange(new List<Parent>()
                    {
                        new Parent()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        FirstName = "Test",
                        LastName = "Making",
                        Email = "test@live.cym",
                        Password = "12345678",
                        HomePhone = "3245234532462",
                        HomeAddress = "testaddress"
                    } ,
                         new Parent()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        FirstName = "Test2",
                        LastName = "Making2",
                        Email = "test@live.cym",
                        Password = "12345678",
                        HomePhone = "3245234532462",
                        HomeAddress = "testaddress"
                    }
                    });
                
                
                    context.Schools.AddRange(new List<School>()
                    {
                        new School()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        SchoolName = "Testschool",
                        Level = EducationLevel.PrimarySchool,
                        Rate = 58,
                        Capacity = 1222, 
                    },
                             
                        new School()
                    {
                       
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        SchoolName = "Testschool2",
                        Level = EducationLevel.PrimarySchool,
                        Rate = 57,
                        Capacity = 1244,
                    }
                    });
                
                
                    context.Students.AddRange(new List<Student>()
                    {
                    new Student()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        FirstName = "Test",
                        LastName = "Maker",
                        BirthDate = DateTime.Now,
                        Gender = (Gender)1,
                        Email = "Test@live.cum",
                        Password = "12345678",
                        Image = "Empty",
                        Grade = (Grade)1,
                        ClassroomId = 21,
                        SchoolId = 24,
                        AvarageScore = 70,
                        AttendanceStatus = AStatus.Continues
                    },
                        new Student()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        FirstName = "Test2",
                        LastName = "Maker4",
                        BirthDate = DateTime.Now,
                        Gender = (Gender)1,
                        Email = "Test@live.cum",
                        Password = "12345678",
                        Image = "Empty",
                        Grade = (Grade)1,
                        ClassroomId = 22,
                        SchoolId = 24,
                        AvarageScore = 75,
                        AttendanceStatus = AStatus.Continues
                    }
                    });
                
               
                    context.Subjects.AddRange(new List<Subject>()
                    {
                        new Subject()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,




                    },
                           new Subject()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,



                    }

                    });
                
               
                    context.SubSubjects.AddRange(new List<SubSubject>()
                    {
                        new SubSubject()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        SubSubjectsName = "testsubsubject",
                        Score = 24,
                        WeeklyClassTime = 5,
                        SubSubjectCredit = 6,
                        Grade = Grade.IX,
                        SubjectId = 22,



                    },
                           new SubSubject()
                    {
                        
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        SubSubjectsName = "testsubsubject2",
                        Score = 24,
                        WeeklyClassTime = 5,
                        SubSubjectCredit = 6,
                        Grade = Grade.IX,
                        SubjectId = 22,
                    }
                    }) ;
                
                    context.Teachers.AddRange(new List<Teacher>()
                    {
                        new Teacher()
                    {
                        Id = 21,
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        FirstName = "testsubsubject",
                        LastName = "testsubsubject",
                        Email = "Test@live.cum",
                        Password = "12345678",
                        Image = "Empty",
                        Branch = "Math",
                        Duty = "none"



                    },
                           new Teacher()
                    {
                        Id = 22,
                        CreateDate = DateTime.Now,
                        Status = (Models.Entities.Abstract.Status)1,
                        FirstName = "testsubsubject2",
                        LastName = "testsubsubject2",
                        Email = "Test@live.cumm",
                        Password = "12345678",
                        Image = "Empty",
                        Branch = "Math",
                        Duty = "none"
                    }
                    });
                context.SaveChanges();
                }
            
        }
    }
}
