using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using static TheDiscAppMVC.Common.Enums.DiscEnums;

namespace TheDiscAppMVC.Models.Disc
{
    public class DiscCreate
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Name (Required)", Prompt = "e.g. Destroyer")]
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
        [Display(Name = "Plastic (Required)", Prompt = "e.g. Star")]
        public string Plastic { get; set; }

        [Display(Name = "Outer Diameter (cm)", Prompt = "e.g. 21.1")]
        public double? OuterDiameter { get; set; }

        [Display(Name = "Inner Diameter (cm)", Prompt = "e.g. 16.7")]
        public double? InnerDiameter { get; set; }

        [Display(Name = "Rim Width (cm)", Prompt = "e.g. 2.2")]
        public double? RimWidth { get; set; }

        [Display(Name = "Height (cm)", Prompt = "e.g. 1.4")]
        public double? Height { get; set; }

        [Display(Name = "Rim Depth (%)", Prompt = "e.g. 5.69")]
        public double? RimDepth { get; set; }

        [Display(Name = "Max Weight (g)", Prompt = "e.g. 176")]
        public double? MaxWeight { get; set; }

        [Display(Name = "Rim Configuration", Prompt = "e.g. 30.5")]
        public double? RimConfiguration { get; set; }

        [Display(Name = "PDGA Approved")]
        public bool? PdgaApproved { get; set; }
    }
}
