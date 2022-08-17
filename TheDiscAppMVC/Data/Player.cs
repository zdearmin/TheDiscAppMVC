using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TheDiscAppMVC.Data
{
    public class Player
    {
        public Player()
        {
            Collections = new HashSet<Collection>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int PdgaNumber { get; set; }
        public int PdgaRating { get; set; }
        public int? TeamId { get; set; }

        public virtual ICollection<Collection> Collections { get; set; }
        public virtual Team Team { get; set; } = null!;
    }
}
