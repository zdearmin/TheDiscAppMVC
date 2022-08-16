namespace TheDiscAppMVC.Models.Disc
{
    public class DiscListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Stability { get; set; }
        public string DiscType { get; set; }
        public int Speed { get; set; }
        public int Glide { get; set; }
        public int Turn { get; set; }
        public int Fade { get; set; }
    }
}
