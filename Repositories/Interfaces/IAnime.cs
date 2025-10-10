using ZAnime.Models;

namespace ZAnime.Repositories.Interfaces
{
    public interface IAnime
    {
        // Get operations
        public Task<IEnumerable<Anime>> GetAnimesAsync();
        public Task<Anime?> GetAnimeByIdAsync(int? id);

        // Create operations
        public Task AddAsync(Anime anime);

        // Update operations
        public Task UpdateAsync(Anime anime);

        // Delete operations
        public Task DeleteAsync(Anime anime);

        // Additional queries
        public Task<bool> TitleExistAsync(string title);
    }
}