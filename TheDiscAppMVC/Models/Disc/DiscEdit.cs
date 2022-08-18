using System.ComponentModel.DataAnnotations;
using static TheDiscAppMVC.Common.Enums.DiscEnums;

namespace TheDiscAppMVC.Models.Disc
{
    public class DiscEdit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Name (Required)")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Brand (Required)")]
        public BrandEnum Brand { get; set; }

        [Required]
        [Display(Name = "Stability (Required)")]
        public StabilityEnum Stability { get; set; }

        [Required]
        [Display(Name = "Disc Type (Required)")]
        public DiscTypeEnum DiscType { get; set; }

        [Required]
        [Display(Name = "Speed (Required)")]
        public SpeedEnum Speed { get; set; }

        [Required]
        [Display(Name = "Glide (Required)")]
        public GlideEnum Glide { get; set; }

        [Required]
        [Display(Name = "Turn (Required)")]
        public TurnEnum Turn { get; set; }

        [Required]
        [Display(Name = "Fade (Required)")]
        public FadeEnum Fade { get; set; }

        [Required]
        [Display(Name = "Plastic (Required)")]
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
