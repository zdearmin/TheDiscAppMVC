using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Data
{
    public class Team
    {
        public Team()
        {
            Players = new HashSet<Player>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
