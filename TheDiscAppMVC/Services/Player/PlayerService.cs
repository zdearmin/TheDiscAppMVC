using TheDiscAppMVC.Data;
using TheDiscAppMVC.Models.Player;

namespace TheDiscAppMVC.Services.Player
{
    public class PlayerService
    {
        private readonly ApplicationDbContext _dbContext;
        public PlayerService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreatePlayer(PlayerCreate model)
        {
            if (model == null)
            {
                return false;
            }

            _dbContext.Players.Add(new Data.Player
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
            });

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }

        public async Task<PlayerDetail> GetPlayerById(int id)
        {
            var player = await _dbContext.Players.FindAsync(id);

            if (player is null)
            {
                return null;
            }

            return new PlayerDetail
            {
                Id = player.Id,
                Name = player.FirstName + " " + player.LastName,
                PdgaNumber = (int)player.PdgaNumber,
                PdgaRating = (int)player.PdgaRating,
                MemberSince = (DateTime)player.MemberSince,
            }
        }
    }
}
