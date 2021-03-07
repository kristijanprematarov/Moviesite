using Moviesite.Data;
using Moviesite.Entities;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moviestore.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _context;

        public MovieRepository(DataContext context)
        {
            this._context = context;
        }

        public void AddMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            Movie movie = GetMovieById(id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public void EditMovie(Movie movie)
        {
            _context.Movies.Update(movie);
            _context.SaveChanges();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            var allMovies = _context.Movies.AsEnumerable();
            return allMovies;
        }

        public Movie GetMovieById(int id)
        {
            var result = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            return result;
        }
    }
}
