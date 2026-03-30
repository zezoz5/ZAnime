using ZAnime.Models;

namespace ZAnime.Repositories.Interfaces
{
    public interface IAnime
    {
        // Get operations
        public Task<IEnumerable<Anime>> GetAnimesAsync();
        public Task<IEnumerable<Anime>> AnimeSearch(string searchString);
        public Task<Anime?> GetAnimeByIdAsync(int? id);

        // Create operations
        public Task AddAnimeAsync(Anime anime);

        // Update operations
        public Task UpdateAnimeAsync(Anime anime);

        // Delete operations
        public Task DeleteAnimeAsync(Anime anime);

        // Additional queries
        public Task<bool> TitleExistAsync(string title);

        // Genre operations
        public Task AddAnimeGenreAsync(int animeId, int genreId);

        

         public Task<IEnumerable<Anime>> FilterByGenre(int genreId);
    }
}