using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Repository.Interfaces
{
    public interface IDirectorRepository
    {
        void AddDirector(Director director);

        void EditDirector(Director director);

        void DeleteDirector(int id);

        Director GetDirectorById(int id);

        IEnumerable<Director> GetAllDirectors();
    }
}
