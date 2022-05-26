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
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(FeleketDbContext db) : base(db)
        {
        }

        public async Task<IEnumerable<Comment>> GetWithWorkByIdAsync(int comId)
        {
            var res = await _db.Comments.Include(c => c.Work).Where(c => c.WorkId == comId).ToListAsync();
            return (res);
        }

        public async Task<IEnumerable<Comment>> GetWitUserByIdAsync(int comId)
        {
            var res = await _db.Comments.Include(c => c.Owner).Where(c => c.OwnerId == comId).ToListAsync();
            return (res);
        }
    }
}
