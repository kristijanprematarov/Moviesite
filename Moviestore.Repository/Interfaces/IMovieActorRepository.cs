using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Repository.Interfaces
{
    public interface IMovieActorRepository
    {
        void AddMovieActors(Actor actor, Movie movie);

        void DeleteMovieActors(MovieActor movieActor);

    }
}
