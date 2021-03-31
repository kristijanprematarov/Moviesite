using Moviesite.Entities;
using Moviesite.Service.Interfaces;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moviesite.Service
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;

        public ActorService(IActorRepository actorRepository)
        {
            this._actorRepository = actorRepository;
        }
        public void Add(Actor actor)
        {
            _actorRepository.AddActor(actor);
        }

        public void Delete(int id)
        {
            _actorRepository.DeleteActor(id);
        }

        public void Edit(Actor actor)
        {
            _actorRepository.EditActor(actor);
        }

        public Actor GetActorById(int id)
        {
            var result = _actorRepository.GetActorById(id);
            return result;
        }

        public IEnumerable<Actor> GetAllActors()
        {
            var result = _actorRepository.GetAllActors();
            return result;
        }

        public string GetAllActorNames(int[] actorIds)
        {
            string actorNames = "";

            if (actorIds.Length > 0)
            {
                foreach (var actorId in actorIds)
                {
                    var lastItem = actorIds.Last();
                    var getActor = _actorRepository.GetActorById(actorId);
                    actorNames += actorId.Equals(lastItem) ? getActor.Name : getActor.Name + ", ";
                }
            }

            return actorNames;
        }
    }
}
