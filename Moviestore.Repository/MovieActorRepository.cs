namespace Moviestore.Repository
{
    using Moviesite.Data;
    using Moviesite.Entities;
    using Moviestore.Repository.Interfaces;
    using System.Collections.Generic;

    public class MovieActorRepository : IMovieActorRepository
    {
        private readonly DataContext _context;

        public MovieActorRepository(DataContext context)
        {
            _context = context;
        }

        public void AddMovieActor(Actor actor, Movie movie)
        {
            var movieActor = new MovieActor { MovieID = movie.Id, ActorID = actor.Id };
            _context.MovieActors.Add(movieActor);
            _context.SaveChanges();
        }

        public void AddMovieActorsList(List<MovieActor> movieActors)
        {
            _context.MovieActors.AddRange(movieActors);
            _context.SaveChanges();
        }

        public void DeleteMovieActor(MovieActor movieActor)
        {
            _context.MovieActors.Remove(movieActor);
            _context.SaveChanges();
        }
    }
}
