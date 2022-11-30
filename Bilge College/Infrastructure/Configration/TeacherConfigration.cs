using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.FirstName).IsRequired().HasColumnType("Varchar");
            builder.Property(x => x.LastName).IsRequired().HasColumnType("Varchar");
            builder.Property(x => x.Email).HasColumnType("Varchar");
            builder.Property(x => x.Password).HasColumnType("Varchar");
            builder.Property(x => x.Image).HasColumnType("Varchar");
            builder.Ignore(x => x.UploadImage);
            builder.Property(x => x.Branch).HasColumnType("Varchar");
            builder.Property(x => x.Duty).HasColumnType("Varchar");
        }
    }
}

