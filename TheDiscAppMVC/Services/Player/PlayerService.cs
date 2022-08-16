using Microsoft.EntityFrameworkCore;
using TheDiscAppMVC.Data;
using TheDiscAppMVC.Models.Player;

namespace TheDiscAppMVC.Services.Player
{
    public class PlayerService : IPlayerService
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
                Name = model.Name,
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
                Name = player.Name
            };
        }

        public async Task<IEnumerable<PlayerListItem>> GetAllPlayers()
        {
            var player = await _dbContext.Players.Select(player => new PlayerListItem
            {
                Id = player.Id,
                Name = player.Name
            })
                .ToListAsync();
            return player;
        }

        public async Task<bool> UpdatePlayer(PlayerEdit model)
        {
            var player = await _dbContext.Players.FindAsync(model.Id);

            if (player is null)
            {
                return false;
            }

            player.Name = model.Name;   

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> DeletePlayer(int id)
        {
            var player = _dbContext.Players.Find(id);

            if (player is null)
            {
                return false;
            }

            _dbContext.Players.Remove(player);

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }
    }
}
