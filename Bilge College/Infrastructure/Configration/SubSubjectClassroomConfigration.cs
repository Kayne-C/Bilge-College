using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class SubSubjectClassroomConfiguration : IEntityTypeConfiguration<SubSubjectClassroom>
    {
        public void Configure(EntityTypeBuilder<SubSubjectClassroom> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.SubSubjectId, x.ClassroomId });
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Datetime2(7)");
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Datetime2(7)");
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Datetime2(7)");
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.HasOne(x => x.SubSubject).WithMany(x => x.SubSubjectClassrooms).HasForeignKey(x => x.SubSubjectId);
            builder.HasOne(x => x.Classroom).WithMany(x => x.SubSubjectClassrooms).HasForeignKey(x => x.ClassroomId);
            builder.Property(x => x.Day).IsRequired(false).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.PeriodNumber).IsRequired(true).HasColumnType("INT").HasMaxLength(2);
            builder.HasOne(x => x.Teacher).WithMany(x => x.SubSubjectClassrooms).HasForeignKey(x => x.TeacherId);
            builder.HasData(
                new SubSubjectClassroom()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SubSubjectId = 60,
                    ClassroomId = 24,
                    Day = "Pazartesi",
                    PeriodNumber = 1,
                    TeacherId = 63,
                },
                new SubSubjectClassroom()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SubSubjectId = 61,
                    ClassroomId = 24,
                    Day = "Pazartesi",
                    PeriodNumber = 2,
                    TeacherId = 64,
                },
                new SubSubjectClassroom()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SubSubjectId = 62,
                    ClassroomId = 24,
                    Day = "Pazartesi",
                    PeriodNumber = 3,
                    TeacherId = 65,
                },
                new SubSubjectClassroom()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SubSubjectId = 61,
                    ClassroomId = 25,
                    Day = "Salı",
                    PeriodNumber = 1,
                    TeacherId = 64,
                },
                new SubSubjectClassroom()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SubSubjectId = 62,
                    ClassroomId = 26,
                    Day = "Çarşamba",
                    PeriodNumber = 1,
                    TeacherId = 65,

                });

        }
    }
}
