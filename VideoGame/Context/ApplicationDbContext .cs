using Microsoft.EntityFrameworkCore;
using System.Configuration;
using VideoGame.Models;

namespace VideoGame.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Studio> Studios { get; set; }
        public DbSet<GameGenre> GameGenres { get; set; }
    }
}
