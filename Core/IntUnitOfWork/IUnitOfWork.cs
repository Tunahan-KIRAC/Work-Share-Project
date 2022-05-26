using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.IntRepository;

namespace CoreLayer.IntUnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; } // add ve savechange arasında eğer olusmussa bunu gerçeklestirebiliriz araya sokma işlemi
        ICategoryRepository Category { get; }
        ICommentRepository Comment { get; }
        IWorkRepository Work { get; }
        void Commit(); // Update ve Remove için
        Task CommitAsync();//bu savechange islemi olacak
    }
}
