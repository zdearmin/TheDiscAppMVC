using TheDiscAppMVC.Models.Player;

namespace TheDiscAppMVC.Services.Player
{
    public interface IPlayerService
    {
        Task<bool> CreatePlayer(PlayerCreate model);
        Task<IEnumerable<PlayerListItem>> GetAllPlayers();
        Task<PlayerDetail> GetPlayerById(int id);
        Task<bool> UpdatePlayer(PlayerEdit model);
        Task<bool> DeletePlayer(int id);
    }
}
