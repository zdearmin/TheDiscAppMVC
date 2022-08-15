using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Player
{
    public class PlayerEdit
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        public int PdgaNumber { get; set; }
        public int PdgaRating { get; set; }
    }
}
