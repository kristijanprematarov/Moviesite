using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Repository.Interfaces
{
    public interface IGenreRepository
    {
        void AddGenre(Genre genre);

        void EditGenre(Genre genre);

        void DeleteGenre(int id);

        Genre GetGenreById(int id);

        IEnumerable<Genre> GetAllGenres();
    }
}
