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
    public class UserConfig:IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(s => s.Id).UseIdentityColumn();
            builder.Property(s => s.CreatedOn).HasColumnType("date");
            builder.Property(s => s.Name).HasMaxLength(50).IsRequired();
            builder.Property(s => s.LastName).HasMaxLength(50).IsRequired();
            builder.Property(s => s.UserName).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Email).HasMaxLength(100).IsRequired();
            builder.Property(s => s.Password).HasMaxLength(50).IsRequired();
            
            
            
            builder.ToTable("tblUsers");


        }

    }
}
