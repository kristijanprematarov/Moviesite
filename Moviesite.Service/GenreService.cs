using Moviesite.Entities;
using Moviesite.Service.Interfaces;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviesite.Service
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            this._genreRepository = genreRepository;
        }
        public void Add(Genre genre)
        {
            _genreRepository.AddGenre(genre);
        }

        public void Delete(int id)
        {
            _genreRepository.DeleteGenre(id);
        }

        public void Edit(Genre genre)
        {
            _genreRepository.EditGenre(genre);
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            var result = _genreRepository.GetAllGenres();
            return result;
        }

        public Genre GetGenreById(int id)
        {
            var result = _genreRepository.GetGenreById(id);
            return result;
        }
    }
}
