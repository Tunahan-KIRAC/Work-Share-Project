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
    internal class WorkSeed : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasData(

                new Work{Id = 1,CreatedOn = DateTime.Now,Title = "Acil boya işi",Description = "Evin bir odası boyanacak",Price = 250,ModifiedUserName = "system",CategoryId = 1,IsActive = true,OwnerId = 1,ModifiedOn = DateTime.Now},
                new Work{Id = 2,CreatedOn = DateTime.Now,Title = "Acil elektirik işi",Description = "Evin elektirik tesisatına bakılacak",Price = 500,ModifiedUserName = "system",CategoryId = 2,IsActive = true,OwnerId = 1,ModifiedOn = DateTime.Now},
                new Work{Id = 3,CreatedOn = DateTime.Now,Title = "Acil temizlik işi",Description = "Ev temizlenecek",Price = 75,ModifiedUserName = "system",CategoryId = 3,IsActive = true,OwnerId = 2,ModifiedOn = DateTime.Now}

            );
        }

    }
}
