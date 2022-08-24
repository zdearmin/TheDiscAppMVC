using TheDiscAppMVC.Models.Player;
using TheDiscAppMVC.Models.Disc;
using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Collection
{
    public class CollectionDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        [Display(Name = "Player Id")]
        public int PlayerId { get; set; }
        
        [Display(Name = "Player Name")]
        public string PlayerName { get; set; }
        
        Display(Name = "Diisc Id")]
        public int DiscId { get; set; }
        
        [Display(Name = "Disc Name")]
        public int DiscName { get; set; }
    }
}
