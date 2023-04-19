using Microsoft.EntityFrameworkCore;

namespace ParksLookupApi.Models
{
  public class ParksLookupApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }
    public DbSet<State> States { get; set; }
    public ParksLookupApiContext(DbContextOptions options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      DataJson initialData = new DataJson();
      builder.Entity<State>()
        .HasData(initialData.states);
      builder.Entity<Park>()
        .HasData(initialData.parks);
    }
  }
}