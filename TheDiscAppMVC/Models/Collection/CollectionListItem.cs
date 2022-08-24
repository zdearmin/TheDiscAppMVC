using System.ComponentModel.DataAnnotations;
using TheDiscAppMVC.Models.Player;

namespace TheDiscAppMVC.Models.Collection
{
    public class CollectionListItem
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Number of Players")]
        public int NumOfPlayers { get; set; }

        [Display(Name = "Number of Discs")]
        public int NumOfDiscs { get; set; }
    }
}
