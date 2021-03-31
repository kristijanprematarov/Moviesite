namespace Moviesite.Service.Interfaces
{
    using Moviesite.Entities;
    using System.Collections.Generic;

    public interface IMovieActorService
    {
        void AddMovieActors(Actor actor, Movie movie);

        void AddMovieActorsList(List<MovieActor> movieActors);
    }
}
