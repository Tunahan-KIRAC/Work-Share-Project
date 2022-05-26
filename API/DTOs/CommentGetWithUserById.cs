namespace API.DTOs
{
    public class CommentGetWithUserById:CommentDto
    {
        public ICollection<UserDto> Users { get; set; }
        public int OwnerId { get; set; }
    }
}
