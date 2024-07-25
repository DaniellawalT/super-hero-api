using Microsoft.EntityFrameworkCore;
using SuperHeroAPI_DotNET8.Entities;

namespace SuperHeroAPI_DotNET8.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
