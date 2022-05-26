using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models;

namespace CoreLayer.IntRepository
{
    public interface IWorkRepository : IRepository<Work>
    {
        Task<IEnumerable<Work>> GetWitUserByIdAsync(int wrkId);
        Task<IEnumerable<Work>> GetWitCategoryByIdAsync(int wrkId);
        Task<IEnumerable<Work>> GetWitCommentByIdAsync(int wrkId);
        Task<IEnumerable<Work>> GetAllWithCategoryAsync();
    }
}
