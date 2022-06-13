using System.ComponentModel.DataAnnotations;


namespace API.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alani zorunludur.")]
        public string Title { get; set; }


        

    }
}
