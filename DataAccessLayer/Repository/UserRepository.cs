﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IntRepository;
using CoreLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(FeleketDbContext db) : base(db)
        {
        }

        public async Task<User> GetWitWorkByIdAsync(int usrId)
        {
            return (await _db.Users.Include(u => u.Works).FirstOrDefaultAsync(c => c.Id == usrId))!;
        }

        public async Task<User> GetWitCommentByIdAsync(int usrId)
        {
            return (await _db.Users.Include(u => u.Comments).FirstOrDefaultAsync(c => c.Id == usrId))!;
        }
    }
}