using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models;

namespace CoreLayer.IntRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Task<Category> GetWithWorkByIdAsync(int catId);
    }
}