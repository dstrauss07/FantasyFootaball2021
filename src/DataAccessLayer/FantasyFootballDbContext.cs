using FantasyFootballLibrary;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class FantasyFootballDbContext : DbContext
    {
        public FantasyFootballDbContext(DbContextOptions<FantasyFootballDbContext> options) : base(options) { }
        public virtual DbSet<ExtensionApplied> ExtensionApplied { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<Team> Team { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ExtensionApplied>()
                .HasIndex(p => new { p.PlayerId, p.TeamId })
                .IsUnique(true);
            builder.Entity<ExtensionApplied>()
                .HasOne(p => p.Player)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
