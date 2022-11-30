using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------   
            builder.Ignore(x => x.SubSubjectId);
            builder.HasOne(x => x.SubSubject).WithMany(x => x.Notes);
            builder.Property(x => x.FirstExamScore).HasColumnType("Int");
            builder.Property(x => x.SecondExamScore).HasColumnType("Int");
            builder.Property(x => x.AvarageScore).HasColumnType("Int");
            builder.Ignore(x => x.SchoolReportId);
            builder.HasOne(x => x.SubSubject).WithMany(x => x.Notes);
        }
    }
}
