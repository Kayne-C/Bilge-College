using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Datetime2(7)");
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Datetime2(7)");
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Datetime2(7)");
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------   

            builder.HasOne(x => x.SubSubject).WithMany(x => x.Notes).HasForeignKey(x => x.SubSubjectId);
            builder.Property(x => x.FirstExamScore).IsRequired(true).HasColumnType("Int");
            builder.Property(x => x.SecondExamScore).IsRequired(true).HasColumnType("Int");
            builder.Property(x => x.AvarageScore).IsRequired(true).HasColumnType("Int");
            builder.HasOne(x => x.SchoolReport).WithMany(x => x.Notes).HasForeignKey(x => x.SchoolReportId);
            builder.HasData(
                 new Note()
                 {
                     Id = 30,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectId = 60,
                     FirstExamScore = 60,
                     SecondExamScore = 50,
                     AvarageScore = 55,
                     SchoolReportId = 45,
                 },
                 new Note()
                 {
                     Id = 31,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectId = 61,
                     FirstExamScore = 70,
                     SecondExamScore = 70,
                     AvarageScore = 70,
                     SchoolReportId = 46,

                 },
                 new Note()
                 {
                     Id = 32,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectId = 62,
                     FirstExamScore = 80,
                     SecondExamScore = 80,
                     AvarageScore = 80,
                     SchoolReportId = 47,

                 },
                 new Note()
                 {
                     Id = 33,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectId = 60,
                     FirstExamScore = 70,
                     SecondExamScore = 70,
                     AvarageScore = 70,
                     SchoolReportId = 46,

                 },
                 new Note()
                 {
                     Id = 34,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectId = 62,
                     FirstExamScore = 70,
                     SecondExamScore = 70,
                     AvarageScore = 70,
                     SchoolReportId = 46,

                 },
                 new Note()
                 {
                     Id = 35,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectId = 61,
                     FirstExamScore = 70,
                     SecondExamScore = 70,
                     AvarageScore = 70,
                     SchoolReportId = 46,

                 },
                 new Note()
                 {
                     Id = 36,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectId = 61,
                     FirstExamScore = 36,
                     SecondExamScore = 36,
                     AvarageScore = 36,
                     SchoolReportId = 46,

                 },
                 new Note()
                 {
                     Id = 37,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     SubSubjectId = 61,
                     FirstExamScore = 44,
                     SecondExamScore = 44,
                     AvarageScore = 44,
                     SchoolReportId = 46,

                 },
                  new Note()
                  {
                      Id = 38,
                      CreateDate = DateTime.Now,
                      UpdateDate = null,
                      DeleteDate = null,
                      Status = (Models.Entities.Abstract.Status)1,
                      SubSubjectId = 61,
                      FirstExamScore = 55,
                      SecondExamScore = 55,
                      AvarageScore = 55,
                      SchoolReportId = 46,

                  },
                   new Note()
                   {
                       Id = 39,
                       CreateDate = DateTime.Now,
                       UpdateDate = null,
                       DeleteDate = null,
                       Status = (Models.Entities.Abstract.Status)1,
                       SubSubjectId = 61,
                       FirstExamScore = 80,
                       SecondExamScore = 80,
                       AvarageScore = 80,
                       SchoolReportId = 46,

                   },
                  new Note()
                  {
                      Id = 40,
                      CreateDate = DateTime.Now,
                      UpdateDate = null,
                      DeleteDate = null,
                      Status = (Models.Entities.Abstract.Status)1,
                      SubSubjectId = 61,
                      FirstExamScore = 50,
                      SecondExamScore = 50,
                      AvarageScore = 50,
                      SchoolReportId = 48,

                  },
                  new Note()
                  {
                      Id = 41,
                      CreateDate = DateTime.Now,
                      UpdateDate = null,
                      DeleteDate = null,
                      Status = (Models.Entities.Abstract.Status)1,
                      SubSubjectId = 61,
                      FirstExamScore = 15,
                      SecondExamScore = 15,
                      AvarageScore = 15,
                      SchoolReportId = 48,

                  },
                   new Note()
                   {
                       Id = 46,
                       CreateDate = DateTime.Now,
                       UpdateDate = null,
                       DeleteDate = null,
                       Status = (Models.Entities.Abstract.Status)1,
                       SubSubjectId = 61,
                       FirstExamScore = 10,
                       SecondExamScore = 10,
                       AvarageScore = 10,
                       SchoolReportId = 48,

                   },
                    new Note()
                    {
                        Id = 47,
                        CreateDate = DateTime.Now,
                        UpdateDate = null,
                        DeleteDate = null,
                        Status = (Models.Entities.Abstract.Status)1,
                        SubSubjectId = 61,
                        FirstExamScore = 10,
                        SecondExamScore = 10,
                        AvarageScore = 10,
                        SchoolReportId = 48,

                    },
                     new Note()
                     {
                         Id = 48,
                         CreateDate = DateTime.Now,
                         UpdateDate = null,
                         DeleteDate = null,
                         Status = (Models.Entities.Abstract.Status)1,
                         SubSubjectId = 61,
                         FirstExamScore = 10,
                         SecondExamScore = 10,
                         AvarageScore = 10,
                         SchoolReportId = 48,

                     });
        }
    }
}
