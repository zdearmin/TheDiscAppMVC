namespace TheDiscAppMVC.Models.Collection
{
    public class CollectionDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PlayerListItem Player { get; set; }
        public List<Disc> Discs 
    }
}
