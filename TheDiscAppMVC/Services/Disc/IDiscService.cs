using TheDiscAppMVC.Models.Disc;

namespace TheDiscAppMVC.Services.Disc
{
    public interface IDiscService
    {
        Task<bool> CreateDisc(DiscCreate model);
        Task<IEnumerable<DiscListItem>> GetAllDiscs();
        Task<DiscDetail> GetDiscById(int id);
        Task<bool> UpdateDisc(DiscEdit model);
        Task<bool> DeleteDisc(int id);
    }
}
