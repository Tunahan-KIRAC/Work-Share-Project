using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoreLayer.Models;

namespace CoreLayer.IntService
{
    public interface ICategoryService:IService<Category>
    {
        Task<Category> GetWithWorkByIdAsync(int catId);
        
    }
}
