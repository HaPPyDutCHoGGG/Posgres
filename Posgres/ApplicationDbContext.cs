using Microsoft.EntityFrameworkCore;
using Posgres;
public class ApplicationDbContext : DbContext
{
    public DbSet<Cat> Cats { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=cats_db;Username=postgres;Password=1234");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cat>().ToTable("cats");
    }
}