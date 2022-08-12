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
        public Stability Stability { get; set; }

        [Required]
        public DiscType Type { get; set; }

        [Required]
        public Speed Speed { get; set; }

        [Required]
        public Glide Glide { get; set; }

        [Required]
        public Turn Turn { get; set; }

        [Required]
        public Fade Fade { get; set; }

        [Required]
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

    public enum Stability
    {
        [Display(Name = "Very Overstable")] VOverstable,
        Overtstable,
        Stable,
        Understable,
        [Display(Name = "Very Understable")] VUnderstable
    }

    public enum DiscType
    {
        [Display(Name = "Distance Driver")] DDriver,
        [Display(Name = "Fairway Driver")] FDriver,
        Midrange,
        Putter
    }

    public enum Speed
    {
        [Display(Name = "1")] OneSpeed,
        [Display(Name = "2")] TwoSpeed,
        [Display(Name = "3")] ThreeSpeed,
        [Display(Name = "4")] FourSpeed,
        [Display(Name = "5")] FiveSpeed,
        [Display(Name = "6")] SixSpeed,
        [Display(Name = "7")] SevenSpeed,
        [Display(Name = "8")] EightSpeed,
        [Display(Name = "9")] NineSpeed,
        [Display(Name = "10")] TenSpeed,
        [Display(Name = "11")] ElevenSpeed,
        [Display(Name = "12")] TwelveSpeed,
        [Display(Name = "13")] ThirteenSpeed,
        [Display(Name = "14")] FourteenSpeed,
        [Display(Name = "15")] FifteenSpeed
    }

    public enum Glide
    {
        [Display(Name = "1")] OneGlide,
        [Display(Name = "2")] TwoGlide,
        [Display(Name = "3")] ThreeGlide,
        [Display(Name = "4")] FourGlide,
        [Display(Name = "5")] FiveGlide,
        [Display(Name = "6")] SixGlide,
        [Display(Name = "7")] SevenGlide,
    }

    public enum Turn
    {
        [Display(Name = "+1")] OneGlide,
        [Display(Name = "0")] ZeroGlide,
        [Display(Name = "-1")] NegOneGlide,
        [Display(Name = "-2")] NegTwoGlide,
        [Display(Name = "-3")] NegThreeGlide,
        [Display(Name = "-4")] NegFourGlide,
        [Display(Name = "-5")] NegFiveGlide,
    }

    public enum Fade
    {
        [Display(Name = "0")] ZeroFade,
        [Display(Name = "1")] OneFade,
        [Display(Name = "2")] TwoFade,
        [Display(Name = "3")] ThreeFade,
        [Display(Name = "4")] FourFade,
        [Display(Name = "5")] FiveFade,
    }
}
