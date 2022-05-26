using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1,IsActive  = true,CreatedOn = DateTime.Now,Email = "tuna@gmail.com",IsAdmin = true,Name ="Tunahan",LastName = "Kıraç",Password = "123",UserName = "Feleket",ModifiedOn = DateTime.Now,ModifiedUserName = "system",IsDelete = false},
                new User { Id = 2,IsActive  = true,CreatedOn = DateTime.Now,Email = "efe@gmail.com",IsAdmin = false,Name ="Efe",LastName = "cemal",Password = "123",UserName = "efenbuy",ModifiedOn = DateTime.Now,ModifiedUserName = "system",IsDelete = false}
                
            );
        }
    }
}
