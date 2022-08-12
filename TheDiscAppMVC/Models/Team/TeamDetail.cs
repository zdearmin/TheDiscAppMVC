using TheDiscAppMVC.Models.Player;

namespace TheDiscAppMVC.Models.Team
{
    public class TeamDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PlayerListItem> Players { get; set; }
    }
}
