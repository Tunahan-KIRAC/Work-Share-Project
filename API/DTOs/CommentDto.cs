namespace API.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string ModifiedUserName { get; set; }
        public DateTime? CreatedOn { get; set; }

        public int OwnerId { get; set; }
        public int WorkId { get; set; }
    }
}
