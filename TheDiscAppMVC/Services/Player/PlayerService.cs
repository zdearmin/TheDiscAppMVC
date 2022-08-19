using Microsoft.EntityFrameworkCore;
using TheDiscAppMVC.Data;
using TheDiscAppMVC.Models.Collection;
using TheDiscAppMVC.Models.Disc;
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
            if (model == null || isDuplicateNumber(model.PdgaNumber) == true)
            {
                return false;
            }      

            _dbContext.Players.Add(new Data.Player
            {
                Name = model.Name,
                PdgaNumber = model.PdgaNumber,
                PdgaRating = model.PdgaRating,
                TeamId = model.TeamId
            });


            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }

        public async Task<PlayerDetail> GetPlayerById(int id)
        {
            var player = await _dbContext.Players
                .Include(t => t.Team)
                .Include(c => c.Collections)
                .ThenInclude(d => d.Discs)
                .FirstOrDefaultAsync(p => p.Id == id);
                

            if (player is null)
            {
                return null;
            }

            return new PlayerDetail
            {
                Id = player.Id,
                Name = player.Name,
                PdgaNumber = player.PdgaNumber,
                PdgaRating = player.PdgaRating,
                TeamName = player.Team.Name
            };
        }

        public async Task<IEnumerable<PlayerListItem>> GetAllPlayers()
        {
            var player = await _dbContext.Players
                .Include(t => t.Team)
                .Select(player => new PlayerListItem
            {
                Id = player.Id,
                Name = player.Name,
                TeamName = player.Team.Name
            })
                .ToListAsync();
            return player;
        }

        public async Task<bool> UpdatePlayer(PlayerEdit model)
        {
            var player = await _dbContext.Players.FindAsync(model.Id);

            if (player is null || isDuplicateNumber(model.PdgaNumber) == true)
            {
                return false;
            }

            player.Name = model.Name;   
            player.PdgaNumber = model.PdgaNumber;
            player.PdgaRating = model.PdgaRating;
            player.TeamId = model.TeamId;

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

        private bool isDuplicateNumber(int number)
        {
            return _dbContext.Players.Any(n => n.PdgaNumber == number);
        }
    }
}
