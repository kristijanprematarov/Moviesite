namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Moviesite.Entities;
    using Moviesite.Service.Interfaces;

    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;

        public GenreController(IGenreService genreService)
        {
            _genreService = genreService;
        }

        public IActionResult Index()
        {
            var genresList = _genreService.GetAllGenres();
            return View(genresList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                _genreService.Add(genre);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
