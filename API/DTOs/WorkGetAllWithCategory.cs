using CoreLayer.Models;

namespace API.DTOs
{
    public class WorkGetAllWithCategory:WorkDto
    {
        public Task<ICollection<CategoryDto>>  Categories { get; set; }
    }
}
