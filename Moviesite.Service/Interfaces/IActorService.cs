using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviesite.Service.Interfaces
{
    public interface IActorService
    {
        void Add(Actor actor);

        void Edit(Actor actor);

        void Delete(int id);

        Actor GetActorById(int id);

        IEnumerable<Actor> GetAllActors();

        string GetAllActorNames(int[] actorIds);
    }
}
