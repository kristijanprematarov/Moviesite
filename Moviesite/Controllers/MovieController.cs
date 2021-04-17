namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Moviesite.Entities;
    using Moviesite.Models;
    using Moviesite.Service.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http.Headers;

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

                foreach (var actorId in movieViewModel.ActorIds)
                {
                    var actor = _actorService.GetActorById(actorId);
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
        public IActionResult Edit(int id, Movie movie)
        {
            _movieService.Edit(movie);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var movie = _movieService.GetMovieById(id);
            return View(movie);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = _movieService.GetMovieById(id);
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var movie = _movieService.GetMovieById(id);
            _movieService.Delete(movie.Id);

            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult UploadPhoto()
        {
            //uploadirame slika i sekogas toa mora da se kontrolira so try catch
            //sekogas sakame da go fatime erorot ako ne saka da se upload
            // ajaxot e vsusnost request..eve ti tebe eden povik so e request i zemi nesto od nego
            // imas url kaj da pogodis ama so toj request ti prakjame i file vo pozadina

            try
            {
                var file = Request.Form.Files[0]; // odi u povikot... form datata..zemi go edniot fajl 
                var folderName = Path.Combine("wwwroot", "photos");

                // folderName === ~/photos;

                //treba da mu kazeme zemi ja slikata i treba da ja zacuvas, 
                //zemi go folderot kaj so sakas da ja zacuvas, 
                //pa posle ke ti ja dadam celata pateka na slikata kaj so treba da ja stajs 
                //posle upload ti ke ja zakacis na taa i taa lokacija na server
                //ke go zemes wwwroot i photos --> folder name ke bide photos


                //kaj da go Save fajlot
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                //ZNACI, go zeame fajlot, go prajme imeto na folderot i mu kazuvame kade sea da go zacuva
                //momentalnata pateka koga ke se pusti ova rekovme raboti vo wwwroot
                //so GetCurrentDirectory() --> odime u wwwroot


                //fajlot ni e vo bytes.. pojma neame kako se vikaat tie bajtovi nie mora ime da mu dademe


                //na sekoj povik moze da mu stajme skrien podatok Header/skriena data e toa, toj se slucuva 
                //za da moze da pustime specijalen kod
                //mozeme da pustime specijalen kod koga ke se otvori toj header da se otvori nesto drugo, kako secret code e
                //moze so nasiot povik da inicijalizirame drug povik a sedi nekade vo server ili windows ili klientskata strana
                //vo headerot moze da prajme i kako BackDoor 
                //ako ni zabranat pristap imamebackdoor toj klient koj so zabranil pristap a ne ni platil moze so secret code
                //vnatre vo headerot na povikot da inicijalizirame dr kontroler koj ke mu ja butne app

                //ako ima fajl ke kombinirame pateki i ke zapisime
                //prajme proverka vo Jquery, uste edna proverka tuka
                if (file.Length > 0)
                {
                    //fajlot go citame kako bytestream toj stream ne ni go sodrzi imeto na slikata sakame istoto ime
                    //fileName --> kako ke se vika fajlot
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');//name ke mi go dade so dvojni navodnici i ja sakam da gi trgnam tie navodnici samo imeto da ostane
                    var fullPath = Path.Combine(pathToSave, fileName);//fullPath --> kade da go zakacam ?

                    //DO SEGA PRIPREMAVME KADE DA ZAPISUVAME

                    var dbPath = fileName;

                    //otkako ke go iscitame fajlot po strimovi taka da go iskreirame kaj nas..mu prajme identicna kopija na ona sto go upload
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream); // go kopiram celiot potok na podatoci/bitovi go kopiram vnatre vo file;
                    }

                    //Ok --> od API
                    return Ok(new { dbPath });
                    //otkako ke go Save fajlot kaj nas vo backend vo photos ako e okej vrati mi ja patekata na fajlot kaj se naogja
                }
                else
                {
                    return BadRequest(); //Error 400 ke vrati i znaci deka nesto ni e greska u backendot
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error: " + ex);
                //nesto se desilo na serverot so ne se ispisala cela rabota i ispisi go Exception-ot
            }
        }



        #region Helpers

        #endregion
    }
}
