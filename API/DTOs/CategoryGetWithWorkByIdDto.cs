namespace API.DTOs
{
    public class CategoryGetWithWorkByIdDto:CategoryDto
    {
        public ICollection<WorkDto> Works { get; set; }

    }
}
