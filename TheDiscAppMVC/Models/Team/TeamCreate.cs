using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Team
{
    public class TeamCreate
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Name (Required)", Prompt = "e.g. Innova")]
        public string Name { get; set; }
    }
}
