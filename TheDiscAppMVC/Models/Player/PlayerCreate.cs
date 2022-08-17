using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Player
{
    public class PlayerCreate
    {
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
        public int PdgaNumber { get; set; }
        public int PdgaRating { get; set; }
        public int TeamId { get; set; }

        public IEnumerable<SelectListItem> TeamOptions { get; set; } = new List<SelectListItem>();
    }
}
