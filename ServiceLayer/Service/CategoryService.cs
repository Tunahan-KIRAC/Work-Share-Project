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
    public class CategoryService:Service<Category>,ICategoryService
    {
        public CategoryService(IUnitOfWork unit, IRepository<Category> repo) : base(unit, repo)
        {
        }

        public async Task<Category> GetWithWorkByIdAsync(int catId)
        {
            return await _unit.Category.GetWithWorkByIdAsync(catId);
        }
    }
}
