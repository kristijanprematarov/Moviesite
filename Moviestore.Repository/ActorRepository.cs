using Moviesite.Data;
using Moviesite.Entities;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moviestore.Repository
{
    public class ActorRepository : IActorRepository
    {
        private readonly DataContext _context;

        public ActorRepository(DataContext context)
        {
            this._context = context;
        }

        public void AddActor(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void DeleteActor(int id)
        {
            Actor actor = GetActorById(id);
            _context.Actors.Remove(actor);
            _context.SaveChanges();
        }

        public void EditActor(Actor actor)
        {
            _context.Actors.Update(actor);
            _context.SaveChanges();
        }

        public Actor GetActorById(int id)
        {
            var result = _context.Actors.FirstOrDefault(actor => actor.Id == id);
            return result;
        }

        public IEnumerable<Actor> GetAllActors()
        {
            var allActors = _context.Actors.AsEnumerable();
            return allActors;
        }
    }
}
