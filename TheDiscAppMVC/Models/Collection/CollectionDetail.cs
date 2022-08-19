using TheDiscAppMVC.Models.Player;
using TheDiscAppMVC.Models.Disc;
using System.ComponentModel.DataAnnotations;

namespace TheDiscAppMVC.Models.Collection
{
    public class CollectionDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Number of Players")]
        public int NumOfPlayers { get; set; }
        public int PlayerId { get; set; }
        public List<PlayerListItem> Players { get; set; }

        [Display(Name = "Number of Discs")]
        public int NumOfDiscs { get; set; }
        public int DiscId { get; set; }
        public List<DiscListItem> Discs { get; set; }
    }
}
