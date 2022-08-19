using Microsoft.EntityFrameworkCore;
using TheDiscAppMVC.Data;
using TheDiscAppMVC.Models.Disc;

namespace TheDiscAppMVC.Services.Disc
{
    public class DiscService : IDiscService
    {
        private readonly ApplicationDbContext _dbContext;
        public DiscService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> CreateDisc(DiscCreate model)
        {
            if (model == null)
            {
                return false;
            }

            _dbContext.Discs.Add(new Data.Disc
            {
                Name = model.Name,
                Brand = model.Brand,
                Stability = model.Stability,
                DiscType = model.DiscType,
                Speed = model.Speed,
                Glide = model.Glide,
                Turn = model.Turn,
                Fade = model.Fade,
                Plastic = model.Plastic,
                MaxWeight = model.MaxWeight,
                OuterDiameter = model.OuterDiameter,
                InnerDiameter = model.InnerDiameter,
                RimWidth = model.RimWidth,
                RimDepth = model.RimDepth,
                RimConfiguration = model.RimConfiguration,
                Height = model.Height,
            });

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }

        public async Task<DiscDetail> GetDiscById(int id)
        {
            var disc = await _dbContext.Discs.FindAsync(id);

            if (disc is null)
            {
                return null;
            }

            return new DiscDetail
            {
                Id = disc.Id,
                Name = disc.Name,
                Brand = disc.Brand,
                Stability = disc.Stability,
                DiscType = disc.DiscType,
                Speed = disc.Speed,
                Glide = disc.Glide,
                Turn = disc.Turn,
                Fade = disc.Fade,
                Plastic = disc.Plastic,
                MaxWeight = disc.MaxWeight,
                OuterDiameter = disc.OuterDiameter,
                InnerDiameter = disc.InnerDiameter,
                RimWidth = disc.RimWidth,
                RimDepth = disc.RimDepth,
                RimConfiguration = disc.RimConfiguration,
                Height = disc.Height,
            };
        }

        public async Task<IEnumerable<DiscListItem>> GetAllDiscs()
        {
            var discs = await _dbContext.Discs.Select(disc => new DiscListItem
            {
                Id = disc.Id,
                Name = disc.Name,
                Brand = disc.Brand,
                Stability = disc.Stability,
                DiscType = disc.DiscType,
                Speed = disc.Speed,
                Glide = disc.Glide,
                Turn = disc.Turn,
                Fade = disc.Fade,
            })
                .ToListAsync();
            return discs;
        }

        public async Task<bool> UpdateDisc(DiscEdit model)
        {
            var disc = await _dbContext.Discs.FindAsync(model.Id);

            if (disc is null)
            {
                return false;
            }

            disc.Name = model.Name;
            disc.Brand = model.Brand;
            disc.Stability = model.Stability;
            disc.DiscType = model.DiscType;
            disc.Speed = model.Speed;
            disc.Glide = model.Glide;
            disc.Turn = model.Turn;
            disc.Fade = model.Fade;
            disc.Plastic = model.Plastic;
            disc.MaxWeight = model.MaxWeight;
            disc.OuterDiameter = model.OuterDiameter;
            disc.InnerDiameter = model.InnerDiameter;
            disc.RimWidth = model.RimWidth;
            disc.RimDepth = model.RimDepth;
            disc.RimConfiguration = model.RimConfiguration;
            disc.Height = model.Height;

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }

        public async Task<bool> DeleteDisc(int id)
        {
            var disc = _dbContext.Discs.Find(id);

            if (disc is null)
            {
                return false;
            }

            _dbContext.Discs.Remove(disc);

            if (await _dbContext.SaveChangesAsync() == 1)
            {
                return true;
            }

            return false;
        }
    }
}
