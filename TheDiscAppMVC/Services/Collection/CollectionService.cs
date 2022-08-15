using TheDiscAppMVC.Data;
using TheDiscAppMVC.Models.Collection;

namespace TheDiscAppMVC.Services.Collection
{
    public class CollectionService
    {
        private readonly ApplicationDbContext _dbContext;
        public CollectionService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateCollection(CollectionCreate model)
        {
            if (model == null)
            {
                return false;
            }

            _dbContext.Collections.Add(new Data.Collection
            {
                Name = model.Name,
            });

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }

        public async Task<CollectionDetail> GetCollectionById(int id)
        {
            var collection = await _dbContext.Collections.FindAsync(id);

            if (collection is null)
            {
                return null;
            }

            return new CollectionDetail
            {
                Id = collection.Id
                
            }
        }
    }
}
