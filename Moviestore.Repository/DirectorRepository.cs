using Moviesite.Data;
using Moviesite.Entities;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moviestore.Repository
{
    public class DirectorRepository : IDirectorRepository
    {
        private readonly DataContext _context;

        public DirectorRepository(DataContext context)
        {
            this._context = context;
        }

        public void AddDirector(Director director)
        {
            _context.Directors.Add(director);
            _context.SaveChanges();
        }

        public void DeleteDirector(int id)
        {
            Director director = GetDirectorById(id);
            _context.Directors.Remove(director);
            _context.SaveChanges();
        }

        public void EditDirector(Director director)
        {
            _context.Directors.Update(director);
            _context.SaveChanges();
        }

        public IEnumerable<Director> GetAllDirectors()
        {
            var allDirectors = _context.Directors.AsEnumerable();
            return allDirectors;

        }

        public Director GetDirectorById(int id)
        {
            var result = _context.Directors.FirstOrDefault(director => director.Id == id);
            return result;
        }
    }
}
