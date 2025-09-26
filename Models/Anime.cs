namespace ZAnime.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Season { get; set; } = string.Empty;

        public ICollection<UserAnime> Viewers { get; set; } = [];
        public ICollection<Genre> Genres { get; set; } = [];
    }
}