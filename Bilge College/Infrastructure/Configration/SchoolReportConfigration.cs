using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class SchoolReportConfiguration : IEntityTypeConfiguration<SchoolReport>
    {
        public void Configure(EntityTypeBuilder<SchoolReport> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.HasOne(x => x.Student).WithMany(x => x.SchoolReports).HasForeignKey(x => x.StudentId);
            builder.Property(x => x.Term).IsRequired(true).HasColumnType("INT");
            builder.Property(x => x.AbsentDay).IsRequired(true).HasColumnType("Int");
            builder.HasData(
                new SchoolReport()
                {
                    Id = 45,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    StudentId = 48,
                    Term = (Term)1,
                    AbsentDay = 5,
                },

                new SchoolReport()
                {
                    Id = 46,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    StudentId = 49,
                    Term = (Term)1,
                    AbsentDay = 7,
                },

                new SchoolReport()
                {
                    Id = 47,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    StudentId = 50,
                    Term = (Term)1,
                    AbsentDay = 9,
                },

                new SchoolReport()
                {
                    Id = 48,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)3,
                    StudentId = 49,
                    Term = (Term)2,
                    AbsentDay = 9,
                });      
        }
}
}
