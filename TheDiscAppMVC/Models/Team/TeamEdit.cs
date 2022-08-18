using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Team
{
    public class TeamEdit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Name (Required)")]
        public string Name { get; set; }

        public IEnumerable<SelectListItem> PlayerOptions { get; set; } = new List<SelectListItem>();
    }
}
