using Microsoft.EntityFrameworkCore;
using TheDiscAppMVC.Data;
using TheDiscAppMVC.Models.Player;
using TheDiscAppMVC.Models.Team;

namespace TheDiscAppMVC.Services.Team
{
    public class TeamService : ITeamService
    {
        private readonly ApplicationDbContext _dbContext;
        public TeamService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateTeam(TeamCreate model)
        {
            if (model == null)
            {
                return false;
            }

            _dbContext.Teams.Add(new Data.Team
            {
                Name = model.Name,
            });

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }

        public async Task<TeamDetail> GetTeamById(int id)
        {
            var team = await _dbContext.Teams
                .Include(p => p.Players)
                .FirstOrDefaultAsync(t => t.Id == id);

            var player = await _dbContext.Players.Where(p => p.TeamId == id).ToListAsync();

            if (team is null)
            {
                return null;
            }

            return new TeamDetail
            {
                Id = team.Id,
                Name = team.Name,
                NumOfPlayers = team.Players
                .Where(p => p.TeamId == id)
                .Count(),
                PlayerName = player.Select(p => p.Name.ToString()).ToList(),
            };
        }

        public async Task<IEnumerable<TeamListItem>> GetAllTeams()
        {
            var teams = await _dbContext.Teams
                .Select(team => new TeamListItem
                {
                    Id = team.Id,
                    Name = team.Name,
                    NumOfPlayers = team.Players
                    .Where(p => p.TeamId == team.Id)
                    .Count()
                })
                    .ToListAsync();

            return teams;
        }

        public async Task<bool> UpdateTeam(TeamEdit model)
        {
            var team = await _dbContext.Teams.FindAsync(model.Id);

            if (team is null)
            {
                return false;
            }

            team.Name = model.Name;

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> DeleteTeam(int id)
        {
            var team = _dbContext.Teams.Find(id);

            if (team is null)
            {
                return false;
            }

            _dbContext.Remove(team);

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }
    }
}
