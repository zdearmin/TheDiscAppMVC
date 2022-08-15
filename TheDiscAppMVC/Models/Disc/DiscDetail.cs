namespace TheDiscAppMVC.Models.Disc
{
    public class DiscDetail
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
