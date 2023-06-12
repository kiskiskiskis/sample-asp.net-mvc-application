using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo")]
        public string LogoURL { get; set; }
        [Display(Name = "Name of cinema")]
        public string Name { get; set; }
        [Display(Name = "Description of cinema")]
        public string Description { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}
