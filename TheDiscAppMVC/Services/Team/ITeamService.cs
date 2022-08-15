using TheDiscAppMVC.Models.Team;

namespace TheDiscAppMVC.Services.Team
{
    public interface ITeamService
    {
        Task<bool> CreateTeam(TeamCreate model);
        Task<IEnumerable<TeamListItem>> GetAllTeams();
        Task<TeamDetail> GetTeamById(int id);
        Task<bool> UpdateTeam(TeamEdit model);
        Task<bool> DeleteTeam(int id);
    }
}
