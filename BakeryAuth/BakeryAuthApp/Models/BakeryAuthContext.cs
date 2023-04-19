using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BakeryAuth.Models 
{
  public class BakeryAuthContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<Treat> treats { get; set; }
    public DbSet<Flavor> flavors { get; set; }
    public DbSet<TreatFlavor> treatFlavors { get; set; }
    public BakeryAuthContext(DbContextOptions options) : base(options) { } 
  }
}
