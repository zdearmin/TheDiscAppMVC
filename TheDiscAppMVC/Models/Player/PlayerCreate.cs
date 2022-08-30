using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Player
{
    public class PlayerCreate
    {
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Name (Required)", Prompt = "e.g. Paul McBeth")]
        public string Name { get; set; }

        [Display(Name = "PDGA Number (Required)")]
        public int PdgaNumber { get; set; }

        [Display(Name = "PDGA Rating (Required)")]
        public int PdgaRating { get; set; }

        [Display(Name = "Team (Required)")]
        public int TeamId { get; set; }

        public IEnumerable<SelectListItem> TeamOptions { get; set; } = new List<SelectListItem>();
    }
}
