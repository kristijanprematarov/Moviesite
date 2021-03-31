using Microsoft.AspNetCore.Mvc.Rendering;
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

        void Delete(Movie movie);

        Movie GetMovieById(int id);

        IEnumerable<Movie> GetAllMovies();

        (List<SelectListItem> Genres,
            List<SelectListItem> Producers,
            List<SelectListItem> Directors,
            MultiSelectList Actors) FillDropdowns(
            IEnumerable<Genre> genres,
            IEnumerable<Producer> producers,
            IEnumerable<Director> directors,
            IEnumerable<Actor> actors);
    }
}
