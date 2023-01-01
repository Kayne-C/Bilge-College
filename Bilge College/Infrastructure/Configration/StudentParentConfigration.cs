using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class StudentParentConfiguration : IEntityTypeConfiguration<StudentParent>
    {
        public void Configure(EntityTypeBuilder<StudentParent> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.StudentId, x.ParentId });
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.HasOne(x => x.Student).WithMany(x => x.StudentParent).HasForeignKey(x => x.StudentId);
            builder.HasOne(x => x.Parent).WithMany(x => x.StudentParent).HasForeignKey(x => x.ParentId);
            builder.HasData(
                new StudentParent()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    StudentId = 48,
                    ParentId = 33,
                },
                new StudentParent()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    StudentId = 49,
                    ParentId = 34,
                },
                new StudentParent()
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    StudentId = 50,
                    ParentId = 35,
                });
        }
    }
}
