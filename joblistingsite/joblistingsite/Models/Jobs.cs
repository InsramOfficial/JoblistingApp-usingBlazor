using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace joblistingsite.Models
{
    public class Jobs
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the job title")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the job Category")]
        public string Nature { get; set; }
        [Required(ErrorMessage = "Please enter the job Salary")]
        public string Salary { get; set; }
        [Required(ErrorMessage = "Please enter the job location")]
        public string LastDateToApply { get; set; }
        [Required(ErrorMessage = "Please enter the Last Date To Apply")]
        public string? Image { get; set; }
    
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
