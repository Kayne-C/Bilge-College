using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.SchoolName).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Level).IsRequired(true).HasColumnType("INT");
            builder.Property(x => x.Rate).IsRequired(true).HasColumnType("int");
            builder.Property(x => x.Capacity).IsRequired(true).HasColumnType("int");
            builder.HasData(
                new School()
                {
                    Id = 42,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SchoolName = "Testschool",
                    Level = (EducationLevel)1,
                    Rate = 58,
                    Capacity = 1222,
                },
                new School()
                {
                    Id = 43,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SchoolName = "Testschool2",
                    Level = (EducationLevel)1,
                    Rate = 57,
                    Capacity = 1244,
                },

                new School()
                {
                    Id = 44,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    SchoolName = "Testschool3",
                    Level = (EducationLevel)2,
                    Rate = 67,
                    Capacity = 1253,  
                    });
            //SchoolId=1

        }
}
}
