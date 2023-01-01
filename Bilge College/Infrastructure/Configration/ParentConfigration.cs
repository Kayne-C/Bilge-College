using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
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
            builder.Property(x => x.HomePhone).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.WorkPhone).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.HomeAddress).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.HasData(
                 new Parent()
                 {
                     Id = 33,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     FirstName = "Ezio",
                     LastName = "Auidotore",
                     Email = "ezioauidotore@live.com",
                     Password = "12345678",
                     HomePhone = "123456789",
                     WorkPhone = "123456789",
                     HomeAddress = "NoAddress"
                 },
                 new Parent()
                 {
                     Id = 34,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     FirstName = "Altair",
                     LastName = "Niobe",
                     Email = "altairniobe@live.com",
                     Password = "12345678",
                     HomePhone = "1234567899",
                     WorkPhone = "123456789",
                     HomeAddress = "NoAddress"
                 },
                 new Parent()
                 {
                     Id = 35,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     FirstName = "Claire",
                     LastName = "Redfield",
                     Email = "ezioauidotore@live.com",
                     Password = "12345678",
                     HomePhone = "12345678900",
                     WorkPhone = "123456789",
                     HomeAddress = "NoAddress"     
                 });
                
           
        }
}
}
