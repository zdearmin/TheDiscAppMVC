using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using static TheDiscAppMVC.Common.Enums.DiscEnums;

namespace TheDiscAppMVC.Data
{
    public class Disc
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public BrandEnum Brand { get; set; }
        public StabilityEnum Stability { get; set; }
        public DiscTypeEnum DiscType { get; set; }
        public SpeedEnum Speed { get; set; }
        public GlideEnum Glide { get; set; }
        public TurnEnum Turn { get; set; }
        public FadeEnum Fade { get; set; }
        public string? Plastic { get; set; }
        public double? OuterDiameter { get; set; }
        public double? InnerDiameter { get; set; }
        public double? RimWidth { get; set; }
        public double? Height { get; set; }
        public double? RimDepth { get; set; }
        public double? MaxWeight { get; set; }
        public double? RimConfiguration { get; set; }
    }
}
