using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheDiscAppMVC.Data
{
    public class Team
    {
        public Team()
        {
            Players = new HashSet<Player>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int? PlayerId { get; set; }

        public ICollection<Player> Players { get; set; }
    }
}
