using Microsoft.EntityFrameworkCore;

namespace DAFramework.Models
{
    public class MyWebContext : DbContext
    {
        public MyWebContext(DbContextOptions<MyWebContext> options) : base(options )
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<PlanetModel> planets {set;get;}
    }
}