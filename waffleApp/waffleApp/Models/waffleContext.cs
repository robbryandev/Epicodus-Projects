using Microsoft.EntityFrameworkCore;

namespace waffle.Models
{
    public class waffleContext : DbContext
    {
        public DbSet<People> peoples { get; set; }
        public DbSet<Pizza> pizzas { get; set; }
        public waffleContext(DbContextOptions options) : base(options) { }
    }
}