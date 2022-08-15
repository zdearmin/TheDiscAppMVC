using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Data
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public int? PdgaNumber { get; set; }
        public int? PdgaRating { get; set; }
        public DateTime? MemberSince { get; set; }

        public virtual Collection Collection { get; set; }
        public virtual Team Team { get; set; }
    }
}
