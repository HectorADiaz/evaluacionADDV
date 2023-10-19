using gameApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace gameApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Article> articles { get; set; }
        public DbSet<Attack> attacks { get; set; }
        public DbSet<Defender> defenders { get; set; }
        public DbSet<Game> games { get; set; }
        public DbSet<Manticora> manticoras { get; set; }
        public DbSet<Stock> stocks { get; set; }
    }
}
