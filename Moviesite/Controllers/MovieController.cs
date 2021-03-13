namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Moviesite.Entities;
    using Moviesite.Service.Interfaces;
    using System.Collections.Generic;

    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            this._movieService = movieService;
        }

        public IActionResult Index()
        {
            var movies = _movieService.GetAllMovies();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> Genres = new List<SelectListItem>()
            {
                new SelectListItem() { Text="Adventure", Value="1"},
                new SelectListItem() { Text="Action", Value="2"},
                new SelectListItem() { Text="Sci-Fi", Value="3"},
                new SelectListItem() { Text="Comedy", Value="4"},
            };

            List<SelectListItem> Producers = new List<SelectListItem>()
            {
                new SelectListItem() { Text="Steven Spielberg", Value="1"},
                new SelectListItem() { Text="Frank Marshall", Value="2"},
                new SelectListItem() { Text="Kevin Feige", Value="3"},
                new SelectListItem() { Text="George Lucas", Value="4"},
            };

            List<SelectListItem> Directors = new List<SelectListItem>()
            {
                new SelectListItem() { Text="Joss Whedon", Value="1"},
                new SelectListItem() { Text="Christopher Nolan", Value="2"},
                new SelectListItem() { Text="Michael Bay", Value="3"},
            };

            ViewBag.GenreList = Genres;
            ViewBag.ProducerList = Producers;
            ViewBag.DirectorList = Directors;
            return View();
        }

        [HttpPost]

        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _movieService.Add(movie);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            List<SelectListItem> Genres = new List<SelectListItem>()
            {
                new SelectListItem() { Text="Adventure", Value="1"},
                new SelectListItem() { Text="Action", Value="2"},
                new SelectListItem() { Text="Sci-Fi", Value="3"},
                new SelectListItem() { Text="Comedy", Value="4"},
            };

            List<SelectListItem> Producers = new List<SelectListItem>()
            {
                new SelectListItem() { Text="Steven Spielberg", Value="1"},
                new SelectListItem() { Text="Frank Marshall", Value="2"},
                new SelectListItem() { Text="Kevin Feige", Value="3"},
                new SelectListItem() { Text="George Lucas", Value="4"},
            };

            List<SelectListItem> Directors = new List<SelectListItem>()
            {
                new SelectListItem() { Text="Joss Whedon", Value="1"},
                new SelectListItem() { Text="Christopher Nolan", Value="2"},
                new SelectListItem() { Text="Michael Bay", Value="3"},
            };

            ViewBag.GenreList = Genres;
            ViewBag.ProducerList = Producers;
            ViewBag.DirectorList = Directors;

            var movie = _movieService.GetMovieById(id);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            _movieService.Edit(movie);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
