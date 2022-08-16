using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Collection
{
    public class CollectionCreate
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public int PlayerId { get; set; }

        [Required]
        public int DiscId { get; set; }

        public IEnumerable<SelectListItem> PlayerOptions { get; set; } = new List<SelectListItem>();
        public IEnumerable<SelectListItem> DiscOptions { get; set; } = new List<SelectListItem>();
    }
}
