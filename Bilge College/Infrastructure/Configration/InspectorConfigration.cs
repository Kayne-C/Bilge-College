using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class InspectorConfiguration : IEntityTypeConfiguration<Inspector>
    {
        public void Configure(EntityTypeBuilder<Inspector> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.UpdateDate).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.DeleteDate).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.Status).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.FirstName).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Image).IsRequired(false).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Ignore(x => x.UploadImage);
            builder.Property(x => x.Duty).IsRequired(false).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.HasData(
                new Inspector()
                {
                    Id = 27,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    FirstName = "Jack",
                    LastName = "Sparrow",
                    Email = "jacksparrow@live.com",
                    Password = "12345678",
                    Image = "None",
                    Duty = "Pirate"
                },
                new Inspector()
                {
                    Id = 28,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    FirstName = "Billy",
                    LastName = "Little",
                    Email = "billylittle@live.com",
                    Password = "12345678",
                    Image = "None",
                    Duty = "Maniac"
                },
                new Inspector()
                {
                    Id = 29,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    FirstName = "Buzz",
                    LastName = "Lightyear",
                    Email = "buzzlightyear@live.com",
                    Password = "12345678",
                    Image = "None",
                    Duty = "Astronout"
                });
                
        }
    }
}
