using TheDiscAppMVC.Models.Player;

namespace TheDiscAppMVC.Models.Collection
{
    public class CollectionListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlayerListItem Player { get; set; }
    }
}
