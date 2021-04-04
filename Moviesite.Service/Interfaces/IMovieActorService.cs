namespace Moviesite.Service.Interfaces
{
    using Moviesite.Entities;
    using System.Collections.Generic;

    public interface IMovieActorService
    {
        void AddMovieActor(Actor actor, Movie movie);

        void AddMovieActorsList(List<MovieActor> movieActors);

        void DeleteMovieActor(MovieActor movieActor);
    }
}
