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
        private readonly IGenreService _genreService;
        private readonly IDirectorService _directorService;
        private readonly IProducerService _producerService;
        private readonly IActorService _actorService;

        public MovieController(
            IMovieService movieService,
            IGenreService genreService,
            IDirectorService directorService,
            IProducerService producerService,
            IActorService actorService)
        {
            this._movieService = movieService;
            this._genreService = genreService;
            this._directorService = directorService;
            this._producerService = producerService;
            this._actorService = actorService;
        }

        public IActionResult Index()
        {
            var movies = _movieService.GetAllMovies();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var genres = _genreService.GetAllGenres();
            var producers = _producerService.GetAllProducers();
            var directors = _directorService.GetAllDirectors();
            var actors = _actorService.GetAllActors();

            var dropdowns = _movieService.FillDropdowns(genres, producers, directors, actors);

            ViewBag.GenreList = dropdowns.Genres;
            ViewBag.ProducerList = dropdowns.Producers;
            ViewBag.DirectorList = dropdowns.Directors;
            ViewBag.ActorList = dropdowns.Actors;

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
            var movie = _movieService.GetMovieById(id);
            var genres = _genreService.GetAllGenres();
            var producers = _producerService.GetAllProducers();
            var directors = _directorService.GetAllDirectors();
            var actors = _actorService.GetAllActors();

            var dropdowns = _movieService.FillDropdowns(genres, producers, directors, actors);

            ViewBag.GenreList = dropdowns.Genres;
            ViewBag.ProducerList = dropdowns.Producers;
            ViewBag.DirectorList = dropdowns.Directors;
            ViewBag.ActorList = dropdowns.Actors;


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
