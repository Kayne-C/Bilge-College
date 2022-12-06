using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class StudentNoticeConfiguration : IEntityTypeConfiguration<StudentNotice>
    {
        public void Configure(EntityTypeBuilder<StudentNotice> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.AdminId, x.StudentId });
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.Title).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.HasOne(x => x.Admin).WithMany(x => x.StudentNotices).HasForeignKey(x => x.AdminId);
            builder.HasOne(x => x.Student).WithMany(x => x.StudentNotices).HasForeignKey(x => x.StudentId);
            builder.HasData(
                new StudentNotice()
                {
                    Id = 54,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Title = "Hello",
                    Description = "This is a test notice",
                    AdminId = 21,
                    StudentId = 48,
                },

                new StudentNotice()
                {
                    Id = 55,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Title = "Hello2",
                    Description = "This is a test notice2",
                    AdminId = 22,
                    StudentId = 49,
                },

                new StudentNotice()
                {
                    Id = 56,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Title = "Hello3",
                    Description = "This is a test notice3",
                    AdminId = 23,
                    StudentId = 50,               
                    });
        }
}
}
