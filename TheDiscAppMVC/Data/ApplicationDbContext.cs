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

        public virtual DbSet<Disc> Discs { get; set; }
        public virtual DbSet<Player> Players { get; set; } 
        public virtual DbSet<Collection> Collections { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
    }
}