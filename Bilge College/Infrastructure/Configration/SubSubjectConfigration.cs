using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class SubSubjectConfiguration : IEntityTypeConfiguration<SubSubject>
    {
        public void Configure(EntityTypeBuilder<SubSubject> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.SubSubjectsName).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50); ;
            builder.Property(x => x.WeeklyClassTime).IsRequired(true).HasColumnType("Int");
            builder.Property(x => x.SubSubjectCredit).IsRequired(true).HasColumnType("Int");
            builder.Property(x => x.Grade).IsRequired(true).HasColumnType("INT");
            builder.HasOne(x => x.Subject).WithMany(x => x.SubSubjects).HasForeignKey(x => x.SubjectId);
            builder.HasData(
                 new SubSubject()
                 {
                     Id = 60,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectsName = "SubSubject1",
                     WeeklyClassTime = 5,
                     SubSubjectCredit = 6,
                     Grade = (Grade)1,
                     SubjectId = 57,
                 },
                 new SubSubject()
                 {
                     Id = 61,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectsName = "SubSubject2",
                     WeeklyClassTime = 4,
                     SubSubjectCredit = 5,
                     Grade = (Grade)1,
                     SubjectId = 58,
                 },
                  new SubSubject()
                  {
                      Id = 62,
                      CreateDate = DateTime.Now,
                      UpdateDate = null,
                      DeleteDate = null,
                      Status = (Models.Entities.Abstract.Status)1,
                      SubSubjectsName = "SubSubject3",
                      WeeklyClassTime = 3,
                      SubSubjectCredit = 3,
                      Grade = (Grade)1,
                      SubjectId = 59,
                  
                    });
        }
}
}
