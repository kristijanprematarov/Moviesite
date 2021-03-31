namespace Moviestore.Repository.Interfaces
{
    using Moviesite.Entities;
    using System.Collections.Generic;

    public interface IMovieActorRepository
    {
        void AddMovieActors(Actor actor, Movie movie);

        void AddMovieActorsList(List<MovieActor> movieActors);

        void DeleteMovieActors(MovieActor movieActor);
    }
}
