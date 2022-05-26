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
    public class WorkConfig:IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.CreatedOn).IsRequired();
            builder.Property(s => s.Title).IsRequired().HasMaxLength(100);
            builder.Property(s => s.Description).HasMaxLength(300);
            builder.HasOne(w => w.Category).WithMany(c => c.Works).HasForeignKey(w => w.CategoryId);
            builder.HasOne(w => w.Owner).WithMany(u => u.Works).HasForeignKey(w => w.OwnerId);
            builder.ToTable("tblWorks");


        }
    }
}
