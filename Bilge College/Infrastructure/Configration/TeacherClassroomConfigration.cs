using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class TeacherClassroomConfiguration : IEntityTypeConfiguration<TeacherClassroom>
    {
        public void Configure(EntityTypeBuilder<TeacherClassroom> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.ClassroomId, x.TeacherId });
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.HasOne(x => x.Classroom).WithMany(x => x.TeacherClassrooms).HasForeignKey(x => x.ClassroomId);
            builder.HasOne(x => x.Teacher).WithMany(x => x.TeacherClassrooms).HasForeignKey(x => x.TeacherId);
            builder.HasData(
                 new TeacherClassroom()
                 {
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     ClassroomId = 24,
                     TeacherId = 63,
                 },
                 new TeacherClassroom()
                 {
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     ClassroomId = 25,
                     TeacherId = 64,
                 },
                 new TeacherClassroom()
                 {
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     ClassroomId = 26,
                     TeacherId = 65,      
                    });
        }
}
}
