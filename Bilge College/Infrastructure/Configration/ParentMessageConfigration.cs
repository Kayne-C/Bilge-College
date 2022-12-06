﻿using Bilge_College.Models.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Bilge_College.Infrastructure.Configration
{
    public class ParentMessageConfiguration : IEntityTypeConfiguration<ParentMessage>
    {
        public void Configure(EntityTypeBuilder<ParentMessage> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.AdminId, x.ParentId });
            builder.Property(x => x.CreateDate).IsRequired(true).HasColumnType("Date").HasDefaultValueSql("GetDate()");
            builder.Property(x => x.UpdateDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.DeleteDate).IsRequired(false).HasColumnType("Date");
            builder.Property(x => x.Status).IsRequired(true).HasColumnType("INT");
            //---------------------------------------------------------------------------------------------------------
            builder.Property(x => x.Title).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.Property(x => x.Context).IsRequired(true).HasColumnType("NVARCHAR").HasMaxLength(50);
            builder.HasOne(x => x.Admin).WithMany(x => x.ParentMessages).HasForeignKey(x => x.AdminId);
            builder.HasOne(x => x.Parent).WithMany(x => x.ParentMessages).HasForeignKey(x => x.ParentId);
            builder.HasData(
                 new ParentMessage()
                 {
                     Id = 36,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     Title = "Hello",
                     Context = "This is a test message",
                     AdminId = 21,
                     ParentId = 33,
                 },

                 new ParentMessage()
                 {
                     Id = 37,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     Title = "Hello2",
                     Context = "This is a test message2",
                     AdminId = 22,
                     ParentId = 34,
                 },

                 new ParentMessage()
                 {
                     Id = 38,
                     CreateDate = DateTime.Now,
                     UpdateDate = null,
                     DeleteDate = null,
                     Status = (Models.Entities.Abstract.Status)1,
                     Title = "Hello3",
                     Context = "This is a test message3",
                     AdminId = 23,
                     ParentId = 35,
                 
                  });
        }
}
}
