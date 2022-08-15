using Microsoft.EntityFrameworkCore;
using TheDiscAppMVC.Data;
using TheDiscAppMVC.Models.Collection;

namespace TheDiscAppMVC.Services.Collection
{
    public class CollectionService : ICollectionService
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
                Id = collection.Id,
                Name = collection.Name
            };
        }

        public async Task<IEnumerable<CollectionListItem>> GetAllCollections()
        {
            var collections = await _dbContext.Collections.Select(collection => new CollectionListItem
            {
                Id = collection.Id,
                Name = collection.Name
            })
                .ToListAsync();
            return collections;
        }

        public async Task<bool> UpdateCollection(CollectionEdit model)
        {
            var collection = await _dbContext.Collections.FindAsync(model.Id);

            if (collection is null)
            {
                return false;
            }

            collection.Name = model.Name;

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> DeleteCollection(int id)
        {
            var collection = _dbContext.Collections.Find(id);

            if (collection is null)
            {
                return false;
            }

            _dbContext.Collections.Remove(collection);

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }
    }
}
