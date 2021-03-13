using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviesite.Service.Interfaces
{
    public interface IMovieService
    {
        void Add(Movie movie);

        void Edit(Movie movie);

        void Edit(int id);

        void Delete(int id);

        Movie GetMovieById(int id);

        IEnumerable<Movie> GetAllMovies();
    }
}
