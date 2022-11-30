using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class SchoolReportConfiguration : IEntityTypeConfiguration<SchoolReport>
    {
        public void Configure(EntityTypeBuilder<SchoolReport> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------
            builder.Ignore(x => x.StudentId);
            builder.HasOne(x => x.Student).WithMany(x => x.SchoolReports);
            builder.Property(x => x.Term).IsRequired().HasColumnType("Enum");
            builder.Property(x => x.AbsentDay).IsRequired().HasColumnType("Int");
        }
    }
}
