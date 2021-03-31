namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Moviesite.Entities;
    using Moviesite.Models;
    using Moviesite.Service.Interfaces;
    using System;
    using System.Collections.Generic;

    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly IGenreService _genreService;
        private readonly IDirectorService _directorService;
        private readonly IProducerService _producerService;
        private readonly IActorService _actorService;
        private readonly IMovieActorService _movieActorService;

        public MovieController(
            IMovieService movieService,
            IGenreService genreService,
            IDirectorService directorService,
            IProducerService producerService,
            IActorService actorService,
            IMovieActorService movieActorService)
        {
            _movieService = movieService;
            _genreService = genreService;
            _directorService = directorService;
            _producerService = producerService;
            _actorService = actorService;
            _movieActorService = movieActorService;
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
        public IActionResult Create(MovieViewModel movieViewModel)
        {
            if (ModelState.IsValid)
            {
                var movie = new Movie()
                {
                    Country = movieViewModel.Country,
                    DateAdded = DateTime.Now,
                    Description = movieViewModel.Description,
                    DirectorID = movieViewModel.DirectorID,
                    DirectorName = movieViewModel.DirectorName,
                    Duration = movieViewModel.Duration,
                    FormatType = movieViewModel.FormatType,
                    GenreID = movieViewModel.GenreID,
                    GenreName = movieViewModel.GenreName,
                    Language = movieViewModel.Language,
                    PhotoURL = movieViewModel.PhotoURL,
                    Price = movieViewModel.Price,
                    ProducerID = movieViewModel.ProducerID,
                    ProducerName = movieViewModel.ProducerName,
                    Rating = movieViewModel.Rating,
                    ReleaseDate = movieViewModel.ReleaseDate,
                    Shipping = movieViewModel.Shipping,
                    SoldItems = movieViewModel.SoldItems,
                    Title = movieViewModel.Title,
                    UserId = 1,
                    ActorNames = _actorService.GetAllActorNames(movieViewModel.ActorIds)
                };

                _movieService.Add(movie);

                List<MovieActor> movieActors = new List<MovieActor>();

                foreach (var actorIds in movieViewModel.ActorIds)
                {
                    var actor = _actorService.GetActorById(actorIds);
                    movieActors.Add(new MovieActor { Actor = actor, Movie = movie });
                }

                _movieActorService.AddMovieActorsList(movieActors);
            }
            else
            {
                return BadRequest(ModelState);
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


        #region Helpers

        #endregion
    }
}
