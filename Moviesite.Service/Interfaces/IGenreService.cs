using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviesite.Service.Interfaces
{
    public interface IGenreService
    {
        void Add(Genre genre);

        void Edit(Genre genre);

        void Delete(int id);

        Genre GetGenreById(int id);

        IEnumerable<Genre> GetAllGenres();
    }
}
