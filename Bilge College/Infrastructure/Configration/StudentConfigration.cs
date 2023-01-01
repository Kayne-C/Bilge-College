using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Datetime2(7)");
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.SchoolNumber).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.FirstName).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.BirthDate).IsRequired(true).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.Gender).IsRequired(true).HasColumnType("INT");
            builder.Property(x => x.Email).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Image).IsRequired(false).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Ignore(x => x.UploadImage);
            builder.Property(x => x.Grade).IsRequired(true).HasColumnType("INT");
            builder.HasOne(x => x.Classroom).WithMany(x => x.Students).HasForeignKey(x => x.ClassroomId);
            builder.HasOne(x => x.School).WithMany(x => x.Students).HasForeignKey(x => x.SchoolId);
            builder.Property(x => x.AvarageScore).IsRequired(true).HasColumnType("Int");
            builder.Property(x => x.AttendanceStatus).IsRequired(true).HasColumnType("INT");
            builder.HasData(
                new Student()
                {
                    Id = 48,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SchoolNumber = "103",
                    FirstName = "John",
                    LastName = "Swear",
                    BirthDate = new DateTime(1995, 11, 01),
                    Gender = (Gender)1,
                    Email = "johnswear@live.com",
                    Password = "12345678",
                    Image = "Empty",
                    Grade = (Grade)1,
                    ClassroomId = 24,
                    SchoolId = 42,
                    AvarageScore = 70,
                    AttendanceStatus = (AStatus)1,
                },
               new Student()
               {
                   Id = 49,
                   CreateDate = DateTime.Now,
                   UpdateDate = null,
                   DeleteDate = null,
                   Status = (Models.Entities.Abstract.Status)1,
                   SchoolNumber = "104",
                   FirstName = "Cally",
                   LastName = "Swear",
                   BirthDate = new DateTime(1995, 11, 01),
                   Gender = (Gender)1,
                   Email = "callyswear@live.com",
                   Password = "12345678",
                   Image = "Empty",
                   Grade = (Grade)1,
                   ClassroomId = 25,
                   SchoolId = 43,
                   AvarageScore = 85,
                   AttendanceStatus = (AStatus)1,
               },
                new Student()
                {
                    Id = 50,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SchoolNumber = "105",
                    FirstName = "Klaus",
                    LastName = "Ainzbell",
                    BirthDate = new DateTime(1990, 01, 20),
                    Gender = (Gender)1,
                    Email = "klausainzbell@live.com",
                    Password = "12345678",
                    Image = "Empty",
                    Grade = (Grade)1,
                    ClassroomId = 26,
                    SchoolId = 44,
                    AvarageScore = 90,
                    AttendanceStatus = (AStatus)1,

                });
        }
    }
}
