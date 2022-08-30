using System.ComponentModel.DataAnnotations;
using static TheDiscAppMVC.Common.Enums.DiscEnums;

namespace TheDiscAppMVC.Models.Disc
{
    public class DiscListItem
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
    }
}
