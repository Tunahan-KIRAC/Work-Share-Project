namespace API.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? ProfileImageFileName { get; set; }
        public string ModifiedUserName { get; set; }
        public int Score { get; set; }
    }
}
