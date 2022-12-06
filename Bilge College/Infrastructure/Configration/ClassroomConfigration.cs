using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.Branch).IsRequired(true).HasColumnType("Char");
            builder.Property(x => x.Grade).IsRequired(true).HasColumnType("INT");
            builder.Property(x => x.Capacity).IsRequired(true).HasColumnType("Int");
            builder.HasData(
                new Classroom()
                {
                    Id = 24,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Branch = 'A',
                    Grade = (Grade)1,
                },
                new Classroom()
                {
                    Id = 25,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Branch = 'B',
                    Grade = (Grade)1,
                },
                new Classroom()
                {
                    Id = 26,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Branch = 'C',
                    Grade = (Grade)1,
                });

            //classroomID=1
        }
    }
}
