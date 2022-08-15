using TheDiscAppMVC.Models.Collection;

namespace TheDiscAppMVC.Services.Collection
{
    public interface ICollectionService
    {
        Task<bool> CreateCollection(CollectionCreate model);
        Task<IEnumerable<CollectionListItem>> GetAllCollections();
        Task<CollectionDetail> GetCollectionById(int id);
        Task<bool> UpdateCollection(CollectionEdit model);
        Task<bool> DeleteCollection(int id);
    }
}
