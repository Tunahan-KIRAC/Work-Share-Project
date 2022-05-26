using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Config
{
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.Text).IsRequired().HasMaxLength(50);
            builder.Property(s => s.ModifiedUserName).IsRequired();
            builder.HasOne(c => c.Work).WithMany(w => w.Comments).HasForeignKey(c => c.WorkId);
            builder.HasOne(c => c.Owner).WithMany(u => u.Comments).HasForeignKey(c => c.OwnerId);
            builder.ToTable("tblComments");


        }
    }
}
