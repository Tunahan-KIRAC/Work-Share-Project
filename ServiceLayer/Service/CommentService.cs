using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IntRepository;
using CoreLayer.IntService;
using CoreLayer.IntUnitOfWork;
using CoreLayer.Models;

namespace ServiceLayer.Service
{
    public class CommentService:Service<Comment>,ICommentService
    {
        public CommentService(IUnitOfWork unit, IRepository<Comment> repo) : base(unit, repo)
        {
        }

        public async Task<IEnumerable<Comment>> GetWithWorkByIdAsync(int comId)
        {
           
            return await _unit.Comment.GetWithWorkByIdAsync(comId);
        }

        public async Task<IEnumerable<Comment>> GetWitUserByIdAsync(int comId)
        {
            return await _unit.Comment.GetWitUserByIdAsync(comId);
        }
    }
}
