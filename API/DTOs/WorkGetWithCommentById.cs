namespace API.DTOs
{
    public class WorkGetWithCommentById:WorkDto
    {
        public ICollection<CommentDto> Comments { get; set; }
    }
}
