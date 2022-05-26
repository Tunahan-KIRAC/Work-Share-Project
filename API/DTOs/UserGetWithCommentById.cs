using CoreLayer.Models;

namespace API.DTOs
{
    public class UserGetWithCommentById:UserDto
    {
        public ICollection<CommentDto> Comments { get; set; }
    }
}
