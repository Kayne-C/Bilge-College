using Bilge_College.Models.Entities.Abstract;
using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.DeleteDate).HasColumnType("Date");
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.FirstName).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Image).IsRequired(false).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Ignore(x => x.UploadImage);
            builder.Property(x => x.Duty).IsRequired(false).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.HasData(
                new Admin()
                {
                    Id = 21,
                    FirstName = "Chuck",
                    LastName = "LockWood",
                    Email = "chucklockwood@live.com",
                    Password = "12345678",
                    Image = "None",
                    Duty = "Administrator",
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Status)1,
                },
                new Admin()
                {
                    Id = 22,
                    FirstName = "Sam",
                    LastName = "Winchester",
                    Email = "samwinchester@live.com",
                    Password = "12345678",
                    Image = "None",
                    Duty = "Co-Administrator",
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                },
                new Admin()
                {
                    Id = 23,
                    FirstName = "Dean",
                    LastName = "Winchester",
                    Email = "deanwinchester@live.com",
                    Password = "12345678",
                    Image = "None",
                    Duty = "Co-Administrator",
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                });

        }
    }
}
