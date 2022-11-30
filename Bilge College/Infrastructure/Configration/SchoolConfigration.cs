using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class SchoolConfiguration : IEntityTypeConfiguration<School>
    {
        public void Configure(EntityTypeBuilder<School> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.SchoolName).IsRequired().HasColumnType("Varchar");
            builder.Property(x => x.Level).IsRequired().HasColumnType("Enum");
            builder.Property(x => x.Rate).IsRequired().HasColumnType("int");
            builder.Property(x => x.Capacity).IsRequired().HasColumnType("int");
        }
    }
}
