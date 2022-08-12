using TheDiscAppMVC.Models.Player;
using TheDiscAppMVC.Models.Disc;

namespace TheDiscAppMVC.Models.Collection
{
    public class CollectionDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlayerListItem Player { get; set; }
        public List<DiscListItem> Discs { get; set; }
    }
}
