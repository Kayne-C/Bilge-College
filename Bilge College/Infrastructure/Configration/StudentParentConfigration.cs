using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class StudentParentConfiguration : IEntityTypeConfiguration<StudentParent>
    {
        public void Configure(EntityTypeBuilder<StudentParent> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.StudentId, x.ParentId });
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------
            builder.HasOne(x => x.Student).WithMany(x => x.StudentParent).HasForeignKey(x => x.StudentId);
            builder.HasOne(x => x.Parent).WithMany(x => x.StudentParent).HasForeignKey(x => x.ParentId);

        }
    }
}
