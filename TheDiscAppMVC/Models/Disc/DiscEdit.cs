using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Disc
{
    public class DiscEdit
    {
        public int Id { get; set; }

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
}
