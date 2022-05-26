namespace API.DTOs
{
    public class WorkGetWithCategoryById:WorkDto
    {
        public ICollection<CategoryDto> Categories { get; set; }
    }
}
