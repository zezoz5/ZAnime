using System.ComponentModel;

namespace ZAnime.Models
{
    public class Anime
    {
        public int Id { get; set; }
        
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [DisplayName("Statues")]
        public string State { get; set; } = string.Empty;
        public string Season { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty; // "images/animes/Nisekoi.jpg"

        public ICollection<UserAnime> Viewers { get; set; } = [];
        public ICollection<Genre> Genres { get; set; } = [];
    }
}