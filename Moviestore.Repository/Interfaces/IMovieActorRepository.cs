namespace Moviestore.Repository.Interfaces
{
    using Moviesite.Entities;
    using System.Collections.Generic;

    public interface IMovieActorRepository
    {
        void AddMovieActor(Actor actor, Movie movie);

        void AddMovieActorsList(List<MovieActor> movieActors);

        void DeleteMovieActor(MovieActor movieActor);
    }
}
