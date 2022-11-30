using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class ParentMessageConfiguration : IEntityTypeConfiguration<ParentMessage>
    {
        public void Configure(EntityTypeBuilder<ParentMessage> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.AdminId, x.ParentId });
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.Title).IsRequired().HasColumnType("Varchar");
            builder.Property(x => x.Context).IsRequired().HasColumnType("Varchar");
            builder.HasOne(x => x.Admin).WithMany(x => x.ParentMessages).HasForeignKey(x => x.AdminId);
            builder.HasOne(x => x.Parent).WithMany(x => x.ParentMessages).HasForeignKey(x => x.ParentId);

        }
    }
}
