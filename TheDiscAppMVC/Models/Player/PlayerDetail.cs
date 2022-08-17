using TheDiscAppMVC.Models.Collection;
using TheDiscAppMVC.Models.Team;

namespace TheDiscAppMVC.Models.Player
{
    public class PlayerDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PdgaNumber { get; set; }
        public int PdgaRating { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public List<CollectionListItem> Collections { get; set; }
    }
}
