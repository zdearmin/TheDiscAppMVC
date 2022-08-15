using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TheDiscAppMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        public DbSet<Disc> Discs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Collection> Collections { get; set; }
        public DbSet <Team> Teams { get; set; }
    }
}