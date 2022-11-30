using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class SubSubjectTeacherConfiguration : IEntityTypeConfiguration<SubSubjectTeacher>
    {
        public void Configure(EntityTypeBuilder<SubSubjectTeacher> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.SubSubjectId, x.TeacherId });
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------
            builder.HasOne(x => x.SubSubject).WithMany(x => x.SubSubjectTeachers).HasForeignKey(x => x.SubSubjectId);
            builder.HasOne(x => x.Teacher).WithMany(x => x.SubSubjectTeachers).HasForeignKey(x => x.TeacherId);

        }
    }
}
