using System.ComponentModel;

namespace ZAnime.Models
{
    public class Anime
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [DisplayName("Statues")]
        public string Type { get; set; } = string.Empty;
        public string Studio { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public int Episodes { get; set; }
        public string Season { get; set; } = string.Empty;
        public double Rating { get; set; }
        public string ImageUrl { get; set; } = string.Empty; // "images/animes/Nisekoi.jpg"

        public ICollection<UserAnime> Viewers { get; set; } = [];
        public ICollection<AnimeGenre> AnimeGenres { get; set; } = [];
    }
}