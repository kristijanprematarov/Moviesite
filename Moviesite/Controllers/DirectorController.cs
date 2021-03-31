namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Moviesite.Entities;
    using Moviesite.Service.Interfaces;

    public class DirectorController : Controller
    {
        private readonly IDirectorService _directorService;

        public DirectorController(IDirectorService directorService)
        {
            _directorService = directorService;
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
    }
}
