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
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, Title = "Boya İşleri", ModifiedUserName = "system", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Category { Id = 2, Title = "Elektrik İşleri", ModifiedUserName = "system", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now },
                new Category { Id = 3, Title = "Temizlik İşleri",ModifiedUserName = "system",CreatedOn = DateTime.Now,ModifiedOn = DateTime.Now}
            );
        }
    }
}
