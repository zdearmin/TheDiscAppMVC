using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Team
{
    public class TeamEdit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
    }
}
