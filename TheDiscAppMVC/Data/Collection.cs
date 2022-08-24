using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace TheDiscAppMVC.Data
{
    public class Collection
    {
        public Collection()
        {
            Players = new HashSet<Player>();
            Discs = new HashSet<Disc>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int PlayerId { get; set; }
        public int DiscId { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Disc> Discs { get; set; }
    }
}
