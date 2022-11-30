using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class SubSubjectClassroomConfiguration : IEntityTypeConfiguration<SubSubjectClassroom>
    {
        public void Configure(EntityTypeBuilder<SubSubjectClassroom> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.SubSubjectId, x.ClassroomId });
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------
            builder.HasOne(x => x.SubSubject).WithMany(x => x.SubSubjectClassrooms).HasForeignKey(x => x.SubSubjectId);
            builder.HasOne(x => x.Classroom).WithMany(x => x.SubSubjectClassrooms).HasForeignKey(x => x.ClassroomId);

        }
    }
}
