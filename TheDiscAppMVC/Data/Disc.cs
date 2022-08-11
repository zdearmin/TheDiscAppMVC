using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Data
{
    public class Disc
    {
        public Disc()
        {
            Collections = new HashSet<Collection>();
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Brand Brand { get; set; }
        public double? OuterDiameter { get; set; }
        public double? InnerDiameter { get; set; }
        public double? RimWidth { get; set; }
        public double? Height { get; set; }
        public double? RimDepth { get; set; }
        public double? MaxWeight { get; set; }
        public double? RimConfiguration { get; set; }
        public bool? PdgaApproved { get; set; }
        public DateOnly? ApprovalDate { get; set; }

        public virtual ICollection<Collection> Collections { get; set; }
    }

    public enum Brand
    {
        [Description("3CDiscs")] CDiscs, 
        [Description("Above Ground Level")] AGL,
        Aerobie,
        [Description("Albatross Disc Golf")] AlbatrossDG,
        [Description("Alfa Discs")] AlfaDiscs,
        [Description("All 4 Frisbee")] AFF,
    }
}
