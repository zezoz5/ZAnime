using Microsoft.AspNetCore.Mvc;
using ZAnime.Models;
using ZAnime.Repositories.Interfaces;

namespace ZAnime.Controllers
{
    public class AnimeController : Controller
    {
        private readonly IAnime _anime;
        public AnimeController(IAnime anime)
        {
            _anime = anime;
        }
        public async Task<IActionResult> Index(string searchString)
        {
            IEnumerable<Anime> animeList;

            if (!string.IsNullOrEmpty(searchString))
            {
                animeList = await _anime.AnimeSearch(searchString);
            }
            else
            {
                animeList = await _anime.GetAnimesAsync();
            }

            return View(animeList);
        }

        // Get
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Anime anime)
        {
            // Server Side Validation
            if (await _anime.TitleExistAsync(anime.Title))
            {
                ModelState.AddModelError("Title", "Anime already exists");
            }

            // Null Exception
            if (ModelState.IsValid)
            {
                await _anime.AddAsync(anime);
                return RedirectToAction("Index");
            }
            else
            {
                return View(anime);
            }
        }

        // GET
        public async Task<IActionResult> Edit(int? Id)
        {
            var anime = await _anime.GetAnimeByIdAsync(Id);

            if (anime == null) return NotFound();

            return View(anime);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Anime anime)
        {
            // Null Exception
            if (ModelState.IsValid)
            {
                await _anime.UpdateAsync(anime);
                return RedirectToAction("Index");
            }
            return View(anime);
        }

        // GET
        public async Task<IActionResult> Delete(int? Id)
        {
            var anime = await _anime.GetAnimeByIdAsync(Id);

            if (anime == null) return NotFound();

            return View(anime);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(Anime anime)
        {
            await _anime.DeleteAsync(anime);
            return RedirectToAction("Index");
        }

        // GET
        public async Task<IActionResult> Details(int? Id)
        {
            var anime = await _anime.GetAnimeByIdAsync(Id);
            return View(anime);
        }
    }
}