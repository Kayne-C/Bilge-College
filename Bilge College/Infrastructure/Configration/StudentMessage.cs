using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class StudentMessageConfiguration : IEntityTypeConfiguration<StudentMessage>
    {
        public void Configure(EntityTypeBuilder<StudentMessage> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.AdminId, x.StudentId });
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.Title).IsRequired().HasColumnType("Varchar");
            builder.Property(x => x.Context).IsRequired().HasColumnType("Varchar");
            builder.HasOne(x => x.Admin).WithMany(x => x.StudentMessages).HasForeignKey(x => x.AdminId);
            builder.HasOne(x => x.Student).WithMany(x => x.StudentMessages).HasForeignKey(x => x.StudentId);

        }
    }
}
