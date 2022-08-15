namespace TheDiscAppMVC.Models.Disc
{
    public class DiscListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public Stability Stability { get; set; }
        public DiscType Type { get; set; }
        public Speed Speed { get; set; }
        public Glide Glide { get; set; }
        public Turn Turn { get; set; }
        public Fade Fade { get; set; }
    }
}
