using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheDiscAppMVC.Data
{
    public class Collection
    {
        public Collection()
        {
            Disc = new HashSet<Disc>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey("Player")]
        public int PlayerId { get; set; }

        public virtual ICollection<Disc> Disc { get; set; }
        public virtual Player Player { get; set; }
    }
}
