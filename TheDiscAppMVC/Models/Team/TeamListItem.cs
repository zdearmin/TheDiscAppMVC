using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Team
{
    public class TeamListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Number of Players")]
        public int NumOfPlayers { get; set; }
    }
}
