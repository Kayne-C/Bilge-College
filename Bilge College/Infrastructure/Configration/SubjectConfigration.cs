using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.SubjectName).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.HasData(
                new Subject()
                {
                    Id = 57,
                    SubjectName = "Subject1",
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                },
                new Subject()
                {
                    Id = 58,
                    SubjectName = "Subject2",
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                },
                new Subject()
                {
                    Id = 59,
                    SubjectName = "Subject3",
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    });

        }
 }
}
