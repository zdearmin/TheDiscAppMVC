using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static TheDiscAppMVC.Common.Enums.DiscEnums;

namespace TheDiscAppMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        public virtual DbSet<Disc> Discs { get; set; }
        public virtual DbSet<Player> Players { get; set; } 
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Disc>()
        //        .HasNoKey()
        //        .HasData
        //        (
        //            new Disc { Id = 1, Name = "Destroyer", Brand = (BrandEnum)47, Stability = (StabilityEnum)1, DiscType = 0, Speed = (SpeedEnum)11, Glide = (GlideEnum)4, Turn = (TurnEnum)2, Fade = (FadeEnum)3, Plastic = "Champion", OuterDiameter = 21.1, InnerDiameter = 16.7, RimWidth = 2.2, Height = 1.4, RimDepth = 5.69, MaxWeight = 176, RimConfiguration = 30.5 },
        //            new Disc { Id = 2, Name = "Buzzz", Brand = (BrandEnum)21, Stability = (StabilityEnum)2, DiscType = (DiscTypeEnum)2, Speed = (SpeedEnum)4, Glide = (GlideEnum)3, Turn = (TurnEnum)2, Fade = (FadeEnum)1, Plastic = "Big Z", OuterDiameter = 21.7, InnerDiameter = 19.3, RimWidth = 1.2, Height = 1.9, RimDepth = 5.99, MaxWeight = 180, RimConfiguration = 44 },
        //            new Disc { Id = 3, Name = "Harp", Brand = (BrandEnum)95, Stability = (StabilityEnum)1, DiscType = (DiscTypeEnum)3, Speed = (SpeedEnum)3, Glide = (GlideEnum)2, Turn = (TurnEnum)1, Fade = (FadeEnum)3, Plastic = "Hard", OuterDiameter = 21, InnerDiameter = 19, RimWidth = 1, Height = 1, RimDepth = 4.76, MaxWeight = 176, RimConfiguration = 65 },
        //            new Disc { Id = 4, Name = "Truth", Brand = (BrandEnum)25, Stability = (StabilityEnum)2, DiscType = (DiscTypeEnum)2, Speed = (SpeedEnum)4, Glide = (GlideEnum)4, Turn = (TurnEnum)2, Fade = (FadeEnum)1, Plastic = "Lucid", OuterDiameter = 21.7, InnerDiameter = 18.7, RimWidth = 1.5, Height = 1.7, RimDepth = 5.53, MaxWeight = 180, RimConfiguration = 41.5 },
        //            new Disc { Id = 5, Name = "Aviar", Brand = (BrandEnum)47, Stability = (StabilityEnum)2, DiscType = (DiscTypeEnum)3, Speed = (SpeedEnum)1, Glide = (GlideEnum)2, Turn = (TurnEnum)1, Fade = (FadeEnum)1, Plastic = "Star", OuterDiameter = 21.2, InnerDiameter = 119.4, RimWidth = 0.9, Height = 2, RimDepth = 7.08, MaxWeight = 176, RimConfiguration = 55.75 }
        //        );

        //    builder.Entity<Player>()
        //        .HasOne(t => t.Team)
        //        .WithMany(p => p.Players);

        //    builder.Entity<Player>()
        //        .HasData
        //        (
        //            new Player { Id = 1, Name = "Paul McBeth", PdgaNumber = 27523, PdgaRating = 1055, TeamId = 2 },
        //            new Player { Id = 2, Name = "Ricky Wysocki", PdgaNumber = 38008, PdgaRating = 1049, TeamId = 4 },
        //            new Player { Id = 3, Name = "Calvin Heimburg", PdgaNumber = 45971, PdgaRating = 1039, TeamId = 1 },
        //            new Player { Id = 4, Name = "Eagle McMahon", PdgaNumber = 37817, PdgaRating = 1045, TeamId = 5 },
        //            new Player { Id = 5, Name = "Chris Dickerson", PdgaNumber = 62467, PdgaRating = 1040, TeamId = 2 }
        //        );

        //    builder.Entity<Team>()
        //        .HasNoKey()
        //        .HasData
        //        (
        //            new Team { Id = 1, Name = "Innova" },
        //            new Team { Id = 2, Name = "Discraft" },
        //            new Team { Id = 3, Name = "Westside Discs" },
        //            new Team { Id = 4, Name = "Dynamic Discs" },
        //            new Team { Id = 5, Name = "Discmania" }
        //        );
        //}
    }
}