using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviesite.Service.Interfaces
{
    public interface IProducerService
    {
        void Add(Producer producer);

        void Edit(Producer producer);

        void Delete(int id);

        Producer GetProducerById(int id);

        IEnumerable<Producer> GetAllProducers();
    }
}
