namespace API.DTOs
{
    public class WorkGetWithUserById:WorkDto
    {
        public ICollection<UserDto> Users { get; set; }
    }
}
