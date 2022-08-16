using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Disc
{
    public class DiscCreate
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string DiscType { get; set; }

        [Required]
        public int Speed { get; set; }

        [Required]
        public int Glide { get; set; }

        [Required]
        public int Turn { get; set; }

        [Required]
        public int Fade { get; set; }

        [Required]
        public string Plastic { get; set; }
        public double? OuterDiameter { get; set; }
        public double? InnerDiameter { get; set; }
        public double? RimWidth { get; set; }
        public double? Height { get; set; }
        public double? RimDepth { get; set; }
        public double? MaxWeight { get; set; }
        public double? RimConfiguration { get; set; }
        public bool? PdgaApproved { get; set; }
        public DateTime? ApprovalDate { get; set; }
    }
}
