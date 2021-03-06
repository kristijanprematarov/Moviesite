namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Moviesite.Entities;
    using Moviesite.Service.Interfaces;

    public class GenreController : Controller
    {
        private readonly IGenreService _genreService;
        private readonly ILogger<GenreController> _logger;

        public GenreController(IGenreService genreService, ILogger<GenreController> logger)
        {
            _genreService = genreService;
            this._logger = logger;
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

        [HttpGet]
        public IActionResult Details(int id)
        {
            var genre = _genreService.GetGenreById(id);
            return View(genre);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var genre = _genreService.GetGenreById(id);
            return View(genre);
        }

        [HttpPost]
        public IActionResult Edit(Genre genre)
        {
            _genreService.Edit(genre);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var genre = _genreService.GetGenreById(id);
            return View(genre);
        }

        [HttpPost]
        public IActionResult Delete(Genre genre)
        {
            _genreService.Delete(genre.Id);

            return RedirectToAction(nameof(Index));
        }
    }
}
