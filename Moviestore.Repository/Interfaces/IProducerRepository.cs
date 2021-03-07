using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Repository.Interfaces
{
    public interface IProducerRepository
    {
        void AddProducer(Producer producer);

        void EditProducer(Producer producer);

        void DeleteProducer(int id);

        Producer GetProducerById(int id);

        IEnumerable<Producer> GetAllProducers();
    }
}
