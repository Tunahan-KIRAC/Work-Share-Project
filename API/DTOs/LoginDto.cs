using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "{0} alani zorunludur.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} alani zorunludur.")]
        public string Password { get; set; }
    }
}
