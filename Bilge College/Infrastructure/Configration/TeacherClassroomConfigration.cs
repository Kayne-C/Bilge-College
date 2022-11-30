using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class TeacherClassroomConfiguration : IEntityTypeConfiguration<TeacherClassroom>
    {
        public void Configure(EntityTypeBuilder<TeacherClassroom> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.ClassroomId, x.TeacherId });
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------
            builder.HasOne(x => x.Classroom).WithMany(x => x.TeacherClassrooms).HasForeignKey(x => x.ClassroomId);
            builder.HasOne(x => x.Teacher).WithMany(x => x.TeacherClassrooms).HasForeignKey(x => x.TeacherId);

        }
    }
}
