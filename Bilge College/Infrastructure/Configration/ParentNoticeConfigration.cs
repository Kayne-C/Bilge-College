using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class ParentNoticeConfiguration : IEntityTypeConfiguration<ParentNotice>
    {
        public void Configure(EntityTypeBuilder<ParentNotice> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.AdminId, x.ParentId });
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Datetime2(7)") ;
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.Title).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.HasOne(x => x.Admin).WithMany(x => x.ParentNotices).HasForeignKey(x => x.AdminId);
            builder.HasOne(x => x.Parent).WithMany(x => x.ParentNotices).HasForeignKey(x => x.ParentId);
            builder.HasData(
                new ParentNotice()
                {
                    Id = 39,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Title = "Hello",
                    Description = "This is a test notice",
                    AdminId = 21,
                    ParentId = 33,
                },

                new ParentNotice()
                {
                    Id = 40,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Title = "Hello2",
                    Description = "This is a test notice2",
                    AdminId = 22,
                    ParentId = 34,
                },

                new ParentNotice()
                {
                    Id = 41,
                    CreateDate = DateTime.Now,
                    UpdateDate = null,
                    DeleteDate = null,
                    Status = (Models.Entities.Abstract.Status)1,
                    Title = "Hello3",
                    Description = "This is a test notice3",
                    AdminId = 23,
                    ParentId = 35,
                
                });
                

        }
}
}
