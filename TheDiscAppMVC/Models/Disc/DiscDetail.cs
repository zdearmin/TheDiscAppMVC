namespace TheDiscAppMVC.Models.Disc
{
    public class DiscDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string DiscType { get; set; }
        public int Speed { get; set; }
        public int Glide { get; set; }
        public int Turn { get; set; }
        public int Fade { get; set; }
        public string Plastic { get; set; }
        public double OuterDiameter { get; set; }
        public double InnerDiameter { get; set; }
        public double RimWidth { get; set; }
        public double Height { get; set; }
        public double RimDepth { get; set; }
        public double MaxWeight { get; set; }
        public double RimConfiguration { get; set; }
        public bool PdgaApproved { get; set; }
        public DateTime ApprovalDate { get; set; }
    }
}
