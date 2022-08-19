using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Player
{
    public class PlayerCreate
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Name (Required)", Prompt = "e.g. Paul McBeth")]
        public string Name { get; set; }

        [Display(Name = "PDGA Number", Prompt = "e.g. 27523")]
        public int PdgaNumber { get; set; }

        [Display(Name = "PDGA Rating", Prompt = "e.g. 1055")]
        public int PdgaRating { get; set; }

        [Display(Name = "Team")]
        public int TeamId { get; set; }

        public IEnumerable<SelectListItem> TeamOptions { get; set; } = new List<SelectListItem>();
    }
}
