using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bilge_College.Infrastructure.Configration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired().HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.UpdateDate).HasColumnType("Date");
            builder.Property(x => x.Status).HasColumnType("Enum");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.SchoolNumber).IsRequired().HasColumnType("Varchar");
            builder.Property(x => x.FirstName).IsRequired().HasColumnType("Varchar");
            builder.Property(x => x.LastName).IsRequired().HasColumnType("Varchar");
            builder.Property(x => x.BirthDate).HasColumnType("Date");
            builder.Property(x => x.Gender).IsRequired().HasColumnType("Enum");
            builder.Property(x => x.Email).HasColumnType("Varchar");
            builder.Property(x => x.Password).HasColumnType("Varchar");
            builder.Property(x => x.Image).HasColumnType("Varchar");
            builder.Ignore(x => x.UploadImage);
            builder.Property(x => x.Grade).HasColumnType("Enum");
            builder.Ignore(x => x.ClassroomId);
            builder.HasOne(x => x.Classroom).WithMany(x => x.Students);
            builder.Ignore(x => x.SchoolId);
            builder.HasOne(x => x.School).WithMany(x => x.Students);
            builder.Property(x => x.AvarageScore).IsRequired().HasColumnType("Int");
            builder.Property(x => x.AttendanceStatus).HasColumnType("Enum");
        }
    }
}
