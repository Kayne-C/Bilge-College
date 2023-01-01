using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class StudentMessageConfiguration : IEntityTypeConfiguration<StudentMessage>
    {
        public void Configure(EntityTypeBuilder<StudentMessage> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.AdminId, x.StudentId });
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.Title).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50); ;
            builder.Property(x => x.Context).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50); ;
            builder.HasOne(x => x.Admin).WithMany(x => x.StudentMessages).HasForeignKey(x => x.AdminId);
            builder.HasOne(x => x.Student).WithMany(x => x.StudentMessages).HasForeignKey(x => x.StudentId);
            builder.HasData(
                new StudentMessage()
                {
                    Id = 51,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Title = "Hello",
                    Context = "This is a test message",
                    AdminId = 21,
                    StudentId = 48,
                },
                new StudentMessage()
                {
                    Id = 52,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Title = "Hello2",
                    Context = "This is a test message2",
                    AdminId = 22,
                    StudentId = 49,
                },
                new StudentMessage()
                {
                    Id = 53,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Title = "Hello3",
                    Context = "This is a test message3",
                    AdminId = 23,
                    StudentId = 50,  
                    });               

        }
}
}
