using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Repository.Interfaces
{
    public interface IMovieRepository
    {
        void AddMovie(Movie movie);

        void EditMovie(Movie movie);

        void EditMovie(int id);

        void DeleteMovie(int id);

        Movie GetMovieById(int id);

        IEnumerable<Movie> GetAllMovies();
    }
}
