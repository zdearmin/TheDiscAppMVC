using System.ComponentModel.DataAnnotations;
using static TheDiscAppMVC.Common.Enums.DiscEnums;

namespace TheDiscAppMVC.Models.Disc
{
    public class DiscDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BrandEnum Brand { get; set; }
        public StabilityEnum Stability { get; set; }

        [Display(Name = "Disc Type")]
        public DiscTypeEnum DiscType { get; set; }
        public SpeedEnum Speed { get; set; }
        public GlideEnum Glide { get; set; }
        public TurnEnum Turn { get; set; }
        public FadeEnum Fade { get; set; }
        public string Plastic { get; set; }

        [Display(Name = "Outer Diameter (cm)")]
        public double? OuterDiameter { get; set; }

        [Display(Name = "Inner Diameter (cm)")]
        public double? InnerDiameter { get; set; }

        [Display(Name = "Rim Width (cm)")]
        public double? RimWidth { get; set; }

        [Display(Name = "Height (cm)")]
        public double? Height { get; set; }

        [Display(Name = "Rim Depth (%)")]
        public double? RimDepth { get; set; }

        [Display(Name = "Max Weight (g)")]
        public double? MaxWeight { get; set; }

        [Display(Name = "Rim Configuration")]
        public double? RimConfiguration { get; set; }

        [Display(Name = "PDGA Approved")]
        public bool? PdgaApproved { get; set; }
    }
}
