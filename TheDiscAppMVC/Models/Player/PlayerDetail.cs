using TheDiscAppMVC.Models.Collection;

namespace TheDiscAppMVC.Models.Player
{
    public class PlayerDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PdgaNumber { get; set; }
        public int PdgaRating { get; set; }
        public DateTime MemberSince { get; set; }
        public List<CollectionListItem> Collections { get; set; }
    }
}
