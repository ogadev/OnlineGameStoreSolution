using Microsoft.EntityFrameworkCore;

namespace OnlineGameStore.Models;

public class GameContext : DbContext
{
    public GameContext(DbContextOptions<GameContext> options) : base(options)
    {}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(c => c.Games)
            .WithOne(g => g.Category)
            .HasForeignKey(g => g.CategoryId);

        modelBuilder.Seed();
    }
    public DbSet<Game> Games { get; set; }
    public DbSet<Category> Categories { get; set; }
}
