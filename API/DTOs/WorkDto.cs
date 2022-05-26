namespace API.DTOs
{
    public class WorkDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; } = true;
        public string ModifiedUserName { get; set; }

        public int OwnerId { get; set; }
        public int CategoryId { get; set; }
    }
}
