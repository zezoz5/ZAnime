namespace ZAnime.Models
{
    public class UserAnime
    {
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public int AnimeId { get; set; }
        public Anime Anime { get; set; } = null!;


        public string Progress { get; set; } = string.Empty;
        public double Rating { get; set; }
    }
}