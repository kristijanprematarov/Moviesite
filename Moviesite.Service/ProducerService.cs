using Moviesite.Entities;
using Moviesite.Service.Interfaces;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviesite.Service
{
    public class ProducerService : IProducerService
    {
        private readonly IProducerRepository _producerRepository;

        public ProducerService(IProducerRepository producerRepository)
        {
            this._producerRepository = producerRepository;
        }

        public void Add(Producer producer)
        {
            _producerRepository.AddProducer(producer);
        }

        public void Delete(int id)
        {
            _producerRepository.DeleteProducer(id);
        }

        public void Edit(Producer producer)
        {
            _producerRepository.EditProducer(producer);
        }

        public IEnumerable<Producer> GetAllProducers()
        {
            var result = _producerRepository.GetAllProducers();
            return result;
        }

        public Producer GetProducerById(int id)
        {
            var result = _producerRepository.GetProducerById(id);
            return result;
        }
    }
}
