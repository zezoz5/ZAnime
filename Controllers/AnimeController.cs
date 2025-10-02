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

        public IActionResult Edit(int? Id)
        {
            if (Id == 0 || Id == null)
                return NotFound();

            var anime = _context.Animes.Find(Id);

            if (anime == null)
                return NotFound();

            return View(anime);
        }

        [HttpPost]
        public IActionResult Edit(Anime anime)
        {
            // Server Side Validation
            if (anime.Title == "My dress up darling")
            {
                ModelState.AddModelError("Title", "Anime already exists");
            }
            // Null Exception
            if (ModelState.IsValid)
            {
                _context.Animes.Update(anime);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(anime);
            }

        }
        public IActionResult Delete(int? Id)
        {
            if (Id == 0 || Id == null)
                return NotFound();

            var anime = _context.Animes.Find(Id);

            if (anime == null)
                return NotFound();

            return View(anime);
        }

        [HttpPost]
        public IActionResult Delete(Anime anime)
        {
            _context.Animes.Remove(anime);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}