using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class SubSubjectConfiguration : IEntityTypeConfiguration<SubSubject>
    {
        public void Configure(EntityTypeBuilder<SubSubject> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.SubSubjectsName).IsRequired().HasColumnType("Varchar");
            builder.Property(x => x.WeeklyClassTime).IsRequired().HasColumnType("Int");
            builder.Property(x => x.SubSubjectCredit).IsRequired().HasColumnType("Int");
            builder.Property(x => x.Grade).IsRequired().HasColumnType("Enum");
            builder.Ignore(x => x.SubjectId);
            builder.HasOne(x => x.Subject).WithMany(x => x.SubSubjects).HasForeignKey(x => x.SubjectId);

        }
    }
}
