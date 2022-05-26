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
    internal class WorkRepository : Repository<Work>, IWorkRepository
    {
        private FeleketDbContext FeleketDbContext { get => _db as FeleketDbContext; }

        public WorkRepository(FeleketDbContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Work>> GetWitUserByIdAsync(int wrkId)
        {
            var res = await _db.Works.Include(w => w.Owner).Where(c => c.OwnerId == wrkId).ToListAsync();
            return (res);
        }

        public async Task<IEnumerable<Work>> GetWitCategoryByIdAsync(int wrkId)
        {
            var res = await _db.Works.Include(w => w.Category).Where(c => c.CategoryId == wrkId).ToListAsync();
            return (res);

        }

        public async Task<IEnumerable<Work>> GetWitCommentByIdAsync(int wrkId)
        {
            var res = await _db.Works.Include(w => w.Comments).Where(c => c.Id == wrkId).ToListAsync();
            return (res);

        }

        public async Task<IEnumerable<Work>> GetAllWithCategoryAsync()
        {
            var works =  FeleketDbContext.Works.Include(s => s.Category).ToListAsync();
            return (await works);
        }
    }
}
