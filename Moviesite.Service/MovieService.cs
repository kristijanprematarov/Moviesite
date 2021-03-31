using Microsoft.AspNetCore.Mvc.Rendering;
using Moviesite.Entities;
using Moviesite.Service.Interfaces;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviesite.Service
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            this._movieRepository = movieRepository;
        }

        public void Add(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        public void Delete(int id)
        {
            _movieRepository.DeleteMovie(id);
        }

        public void Delete(Movie movie)
        {
            _movieRepository.DeleteMovie(movie);
        }

        public void Edit(Movie movie)
        {
            _movieRepository.EditMovie(movie);
        }

        public void Edit(int id)
        {
            var movie = _movieRepository.GetMovieById(id);
            _movieRepository.EditMovie(movie);
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var result = _movieRepository.GetAllMovies();
            return result;
        }

        public Movie GetMovieById(int id)
        {
            var result = _movieRepository.GetMovieById(id);
            return result;
        }

        #region Helper Functions

        public (List<SelectListItem> Genres, List<SelectListItem> Producers, List<SelectListItem> Directors, MultiSelectList Actors)
            FillDropdowns(IEnumerable<Genre> genres, IEnumerable<Producer> producers, IEnumerable<Director> directors, IEnumerable<Actor> actors)
        {

            List<SelectListItem> Genres = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0", Text= "Select genre...",Selected=true}
            };

            List<SelectListItem> Producers = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0", Text= "Select producer...",Selected=true}
            };

            List<SelectListItem> Directors = new List<SelectListItem>()
            {
                new SelectListItem { Value = "0", Text= "Select director...",Selected=true}
            };

            MultiSelectList Actors = new MultiSelectList(actors, "Id", "Name");

            foreach (var genre in genres)
            {
                Genres.Add(new SelectListItem { Value = genre.Id.ToString(), Text = genre.Name });
            }

            foreach (var producer in producers)
            {
                Producers.Add(new SelectListItem { Value = producer.Id.ToString(), Text = producer.Name });
            }

            foreach (var director in directors)
            {
                Directors.Add(new SelectListItem { Value = director.Id.ToString(), Text = director.Name });
            }


            #region OldStaticWay

            //List<SelectListItem> Genres = new List<SelectListItem>()
            //{
            //    new SelectListItem() { Text="Adventure", Value="1"},
            //    new SelectListItem() { Text="Action", Value="2"},
            //    new SelectListItem() { Text="Sci-Fi", Value="3"},
            //    new SelectListItem() { Text="Comedy", Value="4"},
            //};

            //List<SelectListItem> Producers = new List<SelectListItem>()
            //{
            //    new SelectListItem() { Text="Steven Spielberg", Value="1"},
            //    new SelectListItem() { Text="Frank Marshall", Value="2"},
            //    new SelectListItem() { Text="Kevin Feige", Value="3"},
            //    new SelectListItem() { Text="George Lucas", Value="4"},
            //};

            //List<SelectListItem> Directors = new List<SelectListItem>()
            //{
            //    new SelectListItem() { Text="Joss Whedon", Value="1"},
            //    new SelectListItem() { Text="Christopher Nolan", Value="2"},
            //    new SelectListItem() { Text="Michael Bay", Value="3"},
            //};

            //List<SelectListItem> Actors = new List<SelectListItem>()
            //{
            //    new SelectListItem() { Text="Christian Bale", Value="1"},
            //    new SelectListItem() { Text="Chris Hemsworth", Value="2"},
            //};

            #endregion

            return (Genres, Producers, Directors, Actors);
        }

        #endregion




    }
}
