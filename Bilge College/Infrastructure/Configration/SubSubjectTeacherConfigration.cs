using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class SubSubjectTeacherConfiguration : IEntityTypeConfiguration<SubSubjectTeacher>
    {
        public void Configure(EntityTypeBuilder<SubSubjectTeacher> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.SubSubjectId, x.TeacherId });
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.HasOne(x => x.SubSubject).WithMany(x => x.SubSubjectTeachers).HasForeignKey(x => x.SubSubjectId);
            builder.HasOne(x => x.Teacher).WithMany(x => x.SubSubjectTeachers).HasForeignKey(x => x.TeacherId);
            builder.HasData(
                 new SubSubjectTeacher()
                 {
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectId = 60,
                     TeacherId = 63,
                 },
                 new SubSubjectTeacher()
                 {
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectId = 61,
                     TeacherId = 64,
                 },
                 new SubSubjectTeacher()
                 {
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectId = 62,
                     TeacherId = 65,
                 });
        }
    }
}
