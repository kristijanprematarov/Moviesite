using Moviesite.Data;
using Moviesite.Entities;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moviestore.Repository
{
    public class GenreRepository : IGenreRepository
    {
        private readonly DataContext _context;

        public GenreRepository(DataContext context)
        {
            this._context = context;
        }

        public void AddGenre(Genre genre)
        {
            _context.Genres.Add(genre);
            _context.SaveChanges();
        }

        public void DeleteGenre(int id)
        {
            var result = GetGenreById(id);
            _context.Genres.Remove(result);
            _context.SaveChanges();
        }

        public void EditGenre(Genre genre)
        {
            _context.Genres.Update(genre);
            _context.SaveChanges();
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            var result = _context.Genres.AsEnumerable();
            return result;
        }

        public Genre GetGenreById(int id)
        {
            var result = _context.Genres.FirstOrDefault(genre => genre.Id == id);
            return result;
        }
    }
}
