using System.ComponentModel.DataAnnotations;
using TheDiscAppMVC.Models.Player;

namespace TheDiscAppMVC.Models.Team
{
    public class TeamDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Number of Players")]
        public int NumOfPlayers { get; set; }
        public int PlayerId { get; set; }
        [Display(Name = "Player")]
        public string PlayerName { get; set; }
        public List<PlayerListItem> Players { get; set; }
    }
}
