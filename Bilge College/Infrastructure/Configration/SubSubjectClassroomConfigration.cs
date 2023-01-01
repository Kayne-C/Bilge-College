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
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.HasOne(x => x.SubSubject).WithMany(x => x.SubSubjectClassrooms).HasForeignKey(x => x.SubSubjectId);
            builder.HasOne(x => x.Classroom).WithMany(x => x.SubSubjectClassrooms).HasForeignKey(x => x.ClassroomId);
            builder.HasData(
                new SubSubjectClassroom()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SubSubjectId = 60,
                    ClassroomId = 24,
                },
                new SubSubjectClassroom()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SubSubjectId = 61,
                    ClassroomId = 25,
                },
                new SubSubjectClassroom()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SubSubjectId = 62,
                    ClassroomId = 26,

                });

        }
    }
}
