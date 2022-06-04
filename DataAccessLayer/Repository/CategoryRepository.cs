using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IntRepository;
using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    internal class CategoryRepository:Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(FeleketDbContext db) : base(db)
        {
        }

        public async Task<Category> GetWithWorkByIdAsync(int catId)
        {
            var woid = _db.Works.FirstOrDefault(w => w.Id == catId)!.CategoryId;
            return (await _db.Categories.Include(s => s.Works).FirstOrDefaultAsync(s => s.Id == woid))!;
        }

        
    }
}
