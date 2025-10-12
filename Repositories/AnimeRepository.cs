using Microsoft.EntityFrameworkCore;
using ZAnime.Data;
using ZAnime.Models;
using ZAnime.Repositories.Interfaces;

namespace ZAnime.Repositories
{
    public class AnimeRepository : IAnime
    {
        private readonly AppDbContext _context;
        public AnimeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Anime>> GetAnimesAsync()
        {
            return await _context.Animes.ToListAsync();
        }

        public async Task<IEnumerable<Anime>> AnimeSearch(string searchTitle)
        {
            return await _context.Animes.Where(a => a.Title.Contains(searchTitle)).ToListAsync();
        }


        public async Task<Anime?> GetAnimeByIdAsync(int? id)
        {
            return await _context.Animes.FindAsync(id);
        }

        public async Task AddAsync(Anime anime)
        {
            await _context.Animes.AddAsync(anime);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Anime anime)
        {
            _context.Animes.Update(anime);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Anime anime)
        {
            _context.Animes.Remove(anime);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> TitleExistAsync(string title)
        {
            if (await _context.Animes.AnyAsync(a => a.Title == title))
            {
                return false;
            }
            return true;
        }
    }

}