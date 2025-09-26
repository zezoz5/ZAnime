namespace ZAnime.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public ICollection<Anime> Animes { get; set; } = [];
    }
}