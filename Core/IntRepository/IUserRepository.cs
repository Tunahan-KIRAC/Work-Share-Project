using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models;

namespace CoreLayer.IntRepository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetWitWorkByIdAsync(int usrId);
        Task<User> GetWitCommentByIdAsync(int usrId);
    }
}
