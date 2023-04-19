using Microsoft.EntityFrameworkCore;

namespace SideBar.Models
{
    public class SideBarContext : DbContext
    {
        public DbSet<Example> Examples { get; set; }
        public SideBarContext(DbContextOptions options) : base(options) { }
    }
}