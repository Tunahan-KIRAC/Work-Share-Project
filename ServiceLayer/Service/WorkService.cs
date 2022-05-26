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
    public class WorkService : Service<Work>, IWorkService
    {
        public WorkService(IUnitOfWork unit, IRepository<Work> repo) : base(unit, repo)
        {
        }

        public async Task<IEnumerable<Work>> GetWitUserByIdAsync(int wrkId)
        {
            return await _unit.Work.GetWitUserByIdAsync(wrkId);
        }

        public async Task<IEnumerable<Work>> GetWitCategoryByIdAsync(int wrkId)
        {
            return await _unit.Work.GetWitCategoryByIdAsync(wrkId);
        }

        public async Task<IEnumerable<Work>> GetWitCommentByIdAsync(int wrkId)
        {
            return await _unit.Work.GetWitCommentByIdAsync(wrkId);
        }

        public async Task<IEnumerable<Work>> GetAllWithCategoryAsync()
        {
            return await _unit.Work.GetAllWithCategoryAsync();
        }
    }
}
