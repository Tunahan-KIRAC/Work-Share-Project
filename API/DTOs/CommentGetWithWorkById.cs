namespace API.DTOs
{
    public class CommentGetWithWorkById:CommentDto
    {
        public Task<ICollection<WorkDto>> Works { get; set; }

    }
}
