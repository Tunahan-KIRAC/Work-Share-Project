using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IntRepository;
using CoreLayer.IntService;
using CoreLayer.IntUnitOfWork;
using CoreLayer.Models;

namespace ServiceLayer.Service
{
    public class UserService : Service<User>, IUserService
    {
        public UserService(IUnitOfWork unit, IRepository<User> repo) : base(unit, repo)
        {
        }

        public async Task<User> GetWitWorkByIdAsync(int usrId)
        {
            return await _unit.User.GetWitWorkByIdAsync(usrId);
        }

        public async Task<User> GetWitCommentByIdAsync(int usrId)
        {
            return await _unit.User.GetWitCommentByIdAsync(usrId);
        }
    }
}
