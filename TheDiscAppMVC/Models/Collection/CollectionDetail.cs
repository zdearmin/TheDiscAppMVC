using TheDiscAppMVC.Models.Player;
using TheDiscAppMVC.Models.Disc;

namespace TheDiscAppMVC.Models.Collection
{
    public class CollectionDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int DiscId { get; set; }
        public string DiscName { get; set; }
    }
}
