using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.FirstName).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Image).IsRequired(false).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Ignore(x => x.UploadImage);
            builder.Property(x => x.Branch).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Duty).IsRequired(false).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.HasData(
                new Teacher()
                {
                    Id = 63,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    FirstName = "William",
                    LastName = "Jones",
                    Email = "williamjones@live.com",
                    Password = "12345678",
                    Image = "Empty",
                    Branch = "Math",
                    Duty = "None"
                },
                new Teacher()
                {
                    Id = 64,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    FirstName = "Moira",
                    LastName = "Barret",
                    Email = "moirabarret@live.com",
                    Password = "12345678",
                    Image = "Empty",
                    Branch = "Physics",
                    Duty = "None"
                },
                new Teacher()
                {
                    Id = 65,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    FirstName = "Gabriel",
                    LastName = "Logan",
                    Email = "gabriellogan@live.com",
                    Password = "12345678",
                    Image = "Empty",
                    Branch = "Biology",
                    Duty = "None"

                });

        }
    }
}

