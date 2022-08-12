using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Collection
{
    public class CollectionEdit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

    }
}
