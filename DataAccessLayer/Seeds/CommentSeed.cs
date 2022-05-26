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
    public class CommentSeed : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment { Id = 1,ModifiedOn = DateTime.Now,OwnerId = 2,Text = "ben yaparım kuzen",WorkId =1,CreatedOn = DateTime.Now,ModifiedUserName = "efenbuy"}
                
                


            );
        }
    }
}
