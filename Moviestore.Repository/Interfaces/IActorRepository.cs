using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Repository.Interfaces
{
    public interface IActorRepository
    {
        void AddActor(Actor actor);

        void EditActor(Actor actor);

        void DeleteActor(int id);

        Actor GetActorById(int id);

        IEnumerable<Actor> GetAllActors();
    }
}
