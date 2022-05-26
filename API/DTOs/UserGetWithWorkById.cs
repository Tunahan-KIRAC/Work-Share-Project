using CoreLayer.Models;

namespace API.DTOs
{
    public class UserGetWithWorkById:UserDto
    {
        public ICollection<WorkDto> Works { get; set; }
    }
}
