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
    }
}
