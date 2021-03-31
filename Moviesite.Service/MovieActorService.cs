namespace Moviesite.Service
{
    using Moviesite.Entities;
    using Moviesite.Service.Interfaces;
    using Moviestore.Repository.Interfaces;
    using System.Collections.Generic;

    public class MovieActorService : IMovieActorService
    {
        private readonly IMovieActorRepository _movieActorRepository;

        public MovieActorService(IMovieActorRepository movieActorRepository)
        {
            _movieActorRepository = movieActorRepository;
        }

        public void AddMovieActors(Actor actor, Movie movie)
        {
            _movieActorRepository.AddMovieActors(actor, movie);
        }

        public void AddMovieActorsList(List<MovieActor> movieActors)
        {
            _movieActorRepository.AddMovieActorsList(movieActors);
        }
    }
}
