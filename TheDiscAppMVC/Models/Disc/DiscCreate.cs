using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using static TheDiscAppMVC.Common.Enums.DiscEnums;

namespace TheDiscAppMVC.Models.Disc
{
    public class DiscCreate
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        public BrandEnum Brand { get; set; }

        [Required]
        public StabilityEnum Stability { get; set; }

        [Required]
        public DiscTypeEnum DiscType { get; set; }

        [Required]
        public SpeedEnum Speed { get; set; }

        [Required]
        public GlideEnum Glide { get; set; }

        [Required]
        public TurnEnum Turn { get; set; }

        [Required]
        public FadeEnum Fade { get; set; }

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
    }
}
