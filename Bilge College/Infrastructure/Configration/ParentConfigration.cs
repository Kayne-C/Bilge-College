using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class ParentConfiguration : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
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
            builder.Property(x => x.HomePhone).HasColumnType("Varchar");
            builder.Property(x => x.WorkPhone).HasColumnType("Varchar");
            builder.Property(x => x.HomeAddress).HasColumnType("Varchar");         
           
        }
    }
}
