using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviesite.Service.Interfaces
{
    public interface IDirectorService
    {
        void Add(Director director);

        void Edit(Director director);

        void Delete(int id);

        Director GetDirectorById(int id);

        IEnumerable<Director> GetAllDirectors();
    }
}
