using Microsoft.AspNetCore.Mvc;
using ZAnime.Data;
using ZAnime.Models;

namespace ZAnime.Controllers
{
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

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        public IActionResult New(Anime anime)
        {
            // Server Side Validation
            if (anime.Title == "My dress up darling")
            {
                ModelState.AddModelError("Title", "Anime already exists");
            } 
            // Null Exception
            if (ModelState.IsValid)
            {
                _context.Animes.Add(anime);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(anime);
            }
        }
    }
}