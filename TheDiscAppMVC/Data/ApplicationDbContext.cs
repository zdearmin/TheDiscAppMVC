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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Disc>()
                .HasData
                (
                    new Disc { Id = 1, Name = "Destroyer", Brand = (BrandEnum)47, Stability = (StabilityEnum)1, DiscType = (DiscTypeEnum)0, Speed = (SpeedEnum)23, Glide = (GlideEnum)9, Turn = (TurnEnum)4, Fade = (FadeEnum)6, Plastic = "Champion", OuterDiameter = 21.1, InnerDiameter = 16.7, RimWidth = 2.2, Height = 1.4, RimDepth = 5.69, MaxWeight = 176, RimConfiguration = 30.5 },
                    new Disc { Id = 2, Name = "Buzzz", Brand = (BrandEnum)21, Stability = (StabilityEnum)2, DiscType = (DiscTypeEnum)2, Speed = (SpeedEnum)9, Glide = (GlideEnum)7, Turn = (TurnEnum)4, Fade = (FadeEnum)2, Plastic = "Big Z", OuterDiameter = 21.7, InnerDiameter = 19.3, RimWidth = 1.2, Height = 1.9, RimDepth = 5.99, MaxWeight = 180, RimConfiguration = 44 },
                    new Disc { Id = 3, Name = "MD3", Brand = (BrandEnum)20, Stability = (StabilityEnum)1, DiscType = (DiscTypeEnum)2, Speed = (SpeedEnum)9, Glide = (GlideEnum)9, Turn = (TurnEnum)2, Fade = (FadeEnum)4, Plastic = "C-Line", OuterDiameter = 21.8, InnerDiameter = 19, RimWidth = 1.4, Height = 1.9, RimDepth = 5.96, MaxWeight = 180, RimConfiguration = 44.5 },
                    new Disc { Id = 4, Name = "Truth", Brand = (BrandEnum)25, Stability = (StabilityEnum)2, DiscType = (DiscTypeEnum)2, Speed = (SpeedEnum)9, Glide = (GlideEnum)9, Turn = (TurnEnum)4, Fade = (FadeEnum)2, Plastic = "Lucid", OuterDiameter = 21.7, InnerDiameter = 18.7, RimWidth = 1.5, Height = 1.7, RimDepth = 5.53, MaxWeight = 180, RimConfiguration = 41.5 },
                    new Disc { Id = 5, Name = "Zenith", Brand = (BrandEnum)62, Stability = (StabilityEnum)1, DiscType = (DiscTypeEnum)0, Speed = (SpeedEnum)21, Glide = (GlideEnum)9, Turn = (TurnEnum)3, Fade = (FadeEnum)4, Plastic = "Neutron", OuterDiameter = 21.2, InnerDiameter = 16.8, RimWidth = 2.2, Height = 1.7, RimDepth = 5.19, MaxWeight = 176, RimConfiguration = 27 }
                );

            builder.Entity<Team>()
                .HasData
                (
                    new Team { Id = 1, Name = "Innova" },
                    new Team { Id = 2, Name = "Discraft" },
                    new Team { Id = 3, Name = "MVP Disc Sports" },
                    new Team { Id = 4, Name = "Dynamic Discs" },
                    new Team { Id = 5, Name = "Discmania" }
                );

            builder.Entity<Player>()
                .HasData
                (
                    new Player { Id = 1, Name = "Paul McBeth", PdgaNumber = 27523, PdgaRating = 1055, TeamId = 2 },
                    new Player { Id = 2, Name = "Ricky Wysocki", PdgaNumber = 38008, PdgaRating = 1049, TeamId = 4 },
                    new Player { Id = 3, Name = "Calvin Heimburg", PdgaNumber = 45971, PdgaRating = 1039, TeamId = 1 },
                    new Player { Id = 4, Name = "Eagle McMahon", PdgaNumber = 37817, PdgaRating = 1045, TeamId = 5 },
                    new Player { Id = 5, Name = "James Conrad", PdgaNumber = 17295, PdgaRating = 1035, TeamId = 3 }
                );

            builder.Entity<Collection>()
                .HasData
                (
                    new Collection { Id = 1, Name = "Paul's Bag", PlayerId = 1, DiscId = 2 },
                    new Collection { Id = 2, Name = "Calvin's Bag", PlayerId = 3, DiscId = 1 },
                    new Collection { Id = 3, Name = "Eagle's Bag", PlayerId = 4, DiscId = 3 },
                    new Collection { Id = 4, Name = "Ricky's Bag", PlayerId = 2, DiscId = 4 },
                    new Collection { Id = 5, Name = "James' Bag", PlayerId = 5, DiscId = 5 }
                );
        }
    }
}