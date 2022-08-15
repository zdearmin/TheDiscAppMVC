﻿using TheDiscAppMVC.Data;
using TheDiscAppMVC.Models.Disc;

namespace TheDiscAppMVC.Services.Disc
{
    public class DiscService
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
                Stability = (Data.Stability)model.Stability,
                Type = (Data.DiscType)model.Type,
                Speed = (Data.Speed)model.Speed,
                Glide = (Data.Glide)model.Glide,
                Turn = (Data.Turn)model.Turn,
                Fade = (Data.Fade)model.Fade,
                Plastic = model.Plastic,
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
                Stability = (Models.Disc.Stability)disc.Stability,
                Type = (Models.Disc.DiscType)disc.DiscType,
                Speed = (Models.Disc.Speed)disc.Speed,
                Glide = (Models.Disc.Glide)disc.Glide,
                Turn = (Models.Disc.Turn)disc.Turn,
                Fade = (Models.Disc.Fade)disc.Fade,
                Plastic = disc.Plastic
            };
        }
    }
}
