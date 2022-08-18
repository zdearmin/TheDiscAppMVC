using System.ComponentModel.DataAnnotations;
using TheDiscAppMVC.Models.Collection;
using TheDiscAppMVC.Models.Team;

namespace TheDiscAppMVC.Models.Player
{
    public class PlayerDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "PDGA Number")]
        public int PdgaNumber { get; set; }

        [Display(Name = "PDGA Rating")]
        public int PdgaRating { get; set; }
        public int TeamId { get; set; }

        [Display(Name = "Team")]
        public string TeamName { get; set; }
        public List<CollectionListItem> Collections { get; set; }
    }
}