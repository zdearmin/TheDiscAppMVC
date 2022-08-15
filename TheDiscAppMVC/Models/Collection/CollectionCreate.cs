using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Collection
{
    public class CollectionCreate
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }
    }
}
