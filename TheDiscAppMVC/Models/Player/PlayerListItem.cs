using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Player
{
    public class PlayerListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Team")]
        public string TeamName { get; set; }
    }
}
