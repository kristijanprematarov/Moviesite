using Moviesite.Entities;
using Moviesite.Service.Interfaces;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviesite.Service
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;

        public DirectorService(IDirectorRepository directorRepository)
        {
            this._directorRepository = directorRepository;
        }
        public void Add(Director director)
        {
            _directorRepository.AddDirector(director);
        }

        public void Delete(int id)
        {
            _directorRepository.DeleteDirector(id);
        }

        public void Edit(Director director)
        {
            _directorRepository.EditDirector(director);
        }

        public IEnumerable<Director> GetAllDirectors()
        {
            var result = _directorRepository.GetAllDirectors();
            return result;
        }

        public Director GetDirectorById(int id)
        {
            var result = _directorRepository.GetDirectorById(id);
            return result;
        }
    }
}
