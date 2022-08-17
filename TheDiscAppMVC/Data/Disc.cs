using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TheDiscAppMVC.Data
{
    public class Disc
    {
        public Disc()
        {
            Collections = new HashSet<Collection>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string DiscType { get; set; }
        public int Speed { get; set; }
        public int Glide { get; set; }
        public int Turn { get; set; }
        public int Fade { get; set; }
        public string Plastic { get; set; }
        public double? OuterDiameter { get; set; }
        public double? InnerDiameter { get; set; }
        public double? RimWidth { get; set; }
        public double? Height { get; set; }
        public double? RimDepth { get; set; }
        public double? MaxWeight { get; set; }
        public double? RimConfiguration { get; set; }
        public bool? PdgaApproved { get; set; }

        public virtual ICollection<Collection> Collections { get; set; }
    }
}
