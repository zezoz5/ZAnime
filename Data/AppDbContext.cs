using Microsoft.EntityFrameworkCore;
using ZAnime.Models;

namespace ZAnime.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<UserAnime>().HasKey(ua => new { ua.AnimeId, ua.UserId });
            model.Entity<AnimeGenre>().HasKey(ag => new { ag.AnimeId, ag.GenreId });

            model.Entity<UserAnime>()
            .HasOne(u => u.User)
            .WithMany(u => u.WatchList)
            .HasForeignKey(ua => ua.UserId);

            model.Entity<UserAnime>()
            .HasOne(a => a.Anime)
            .WithMany(a => a.Viewers)
            .HasForeignKey(ua => ua.AnimeId);

            model.Entity<AnimeGenre>()
            .HasOne(ag => ag.Genre)
            .WithMany(a => a.AnimeGenres)
            .HasForeignKey(ag => ag.GenreId);

            model.Entity<AnimeGenre>()
            .HasOne(ag => ag.Anime)
            .WithMany(a => a.AnimeGenres)
            .HasForeignKey(ag => ag.AnimeId);
        }

        public DbSet<Anime> Animes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAnime> UserAnimes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<AnimeGenre> AnimeGenres { get; set; }
    }
}