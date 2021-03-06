using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models;

namespace CoreLayer.IntService
{
    public interface ICommentService:IService<Comment>
    {
        Task<IEnumerable<Comment>> GetWithWorkByIdAsync(int comId);
        Task<IEnumerable<Comment>> GetWitUserByIdAsync(int comId);
    }
}
