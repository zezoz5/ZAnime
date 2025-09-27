using Microsoft.AspNetCore.Mvc;
using ZAnime.Data;
using ZAnime.Models;

namespace ZAnime.Controllers
{
    [Route("[controller]")]
    public class AnimeController : Controller
    {
        private readonly AppDbContext _context;

        public AnimeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Anime> animeList = _context.Animes.ToList();
            return View(animeList);
        }
    }
}