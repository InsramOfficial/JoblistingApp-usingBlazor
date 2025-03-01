using System.ComponentModel.DataAnnotations;

namespace joblistingsite.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a Category name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a Category description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter the  slug e.g remote-job")]

        public string slug { get; set; }
    }
}
