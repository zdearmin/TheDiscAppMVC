using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Collection
{
    public class CollectionCreate
    {
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Display(Name = "Player")]
        public int PlayerId { get; set; }

        [Display(Name = "Disc")]
        public int DiscId { get; set; }


        public IEnumerable<SelectListItem> PlayerOptions { get; set; } = new List<SelectListItem>();
        public IEnumerable<SelectListItem> DiscOptions { get; set; } = new List<SelectListItem>();
    }
}
