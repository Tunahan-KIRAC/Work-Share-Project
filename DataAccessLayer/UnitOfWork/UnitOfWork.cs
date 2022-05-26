using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IntRepository;
using CoreLayer.IntUnitOfWork;
using DataAccessLayer.Repository;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FeleketDbContext _db;
        private CommentRepository _commentRepository;
        private CategoryRepository _categoryRepository;
        private UserRepository _userRepository;
        private WorkRepository _workRepository;

        public UnitOfWork(FeleketDbContext db)
        {
            _db = db;
        }

        public IUserRepository User => _userRepository ??= new UserRepository(_db);
        public ICategoryRepository Category => _categoryRepository ??= new CategoryRepository(_db);
        public ICommentRepository Comment => _commentRepository ??= new CommentRepository(_db);
        public IWorkRepository Work => _workRepository ??= new WorkRepository(_db);

        public void Commit()
        {
        _db.SaveChanges();
    }

        public async Task CommitAsync()
        {
            await _db.SaveChangesAsync();
        }
    }
}
