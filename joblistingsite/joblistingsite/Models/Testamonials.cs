using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace joblistingsite.Models
{
    public class Testamonials
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter occupation")]

        public string Occupation { get; set; }
        [Required(ErrorMessage = "Please enter review")]

        public string Review { get; set; }
        public string? Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
