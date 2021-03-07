using Moviesite.Data;
using Moviesite.Entities;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moviestore.Repository
{
    public class ProducerRepository : IProducerRepository
    {
        private readonly DataContext _context;

        public ProducerRepository(DataContext context)
        {
            this._context = context;
        }

        public void AddProducer(Producer producer)
        {
            _context.Producers.Add(producer);
            _context.SaveChanges();
        }

        public void DeleteProducer(int id)
        {
            Producer producer = GetProducerById(id);
            _context.Producers.Remove(producer);
            _context.SaveChanges();
        }

        public void EditProducer(Producer producer)
        {
            _context.Producers.Update(producer);
            _context.SaveChanges();
        }

        public IEnumerable<Producer> GetAllProducers()
        {
            var allProducers = _context.Producers.AsEnumerable();
            return allProducers;
        }

        public Producer GetProducerById(int id)
        {
            var result = _context.Producers.FirstOrDefault(producer => producer.Id == id);
            return result;
        }
    }
}
