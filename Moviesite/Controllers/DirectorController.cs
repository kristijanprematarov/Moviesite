namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Moviesite.Entities;
    using Moviesite.Service.Interfaces;

    public class DirectorController : Controller
    {
        private readonly IDirectorService _directorService;
        private readonly ILogger<DirectorController> _logger;

        public DirectorController(IDirectorService directorService, ILogger<DirectorController> logger)
        {
            _directorService = directorService;
            this._logger = logger;
        }

        public IActionResult Index()
        {
            var directorsList = _directorService.GetAllDirectors();
            return View(directorsList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Director director)
        {
            if (ModelState.IsValid)
            {
                _directorService.Add(director);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var director = _directorService.GetDirectorById(id);
            return View(director);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var director = _directorService.GetDirectorById(id);
            return View(director);
        }

        [HttpPost]
        public IActionResult Edit(Director director)
        {
            _directorService.Edit(director);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var director = _directorService.GetDirectorById(id);
            return View(director);
        }

        [HttpPost]
        public IActionResult Delete(Director director)
        {
            _directorService.Delete(director.Id);

            return RedirectToAction(nameof(Index));
        }
    }
}
