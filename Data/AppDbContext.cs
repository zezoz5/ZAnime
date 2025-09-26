using Microsoft.EntityFrameworkCore;
using ZAnime.Models;

namespace ZAnime.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<UserAnime>().HasKey(k => new { k.AnimeId, k.UserId });

            model.Entity<UserAnime>()
            .HasOne(u => u.User)
            .WithMany(u => u.WatchList)
            .HasForeignKey(ua => ua.UserId);

            model.Entity<UserAnime>()
            .HasOne(a => a.Anime)
            .WithMany(a => a.Viewers)
            .HasForeignKey(ua => ua.AnimeId);

            model.Entity<Anime>()
            .HasMany(g => g.Genres)
            .WithMany(a => a.Animes);
        }

        public DbSet<Anime> Animes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAnime> UserAnimes { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}