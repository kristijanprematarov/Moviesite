using Moviesite.Data;
using Moviesite.Entities;
using Moviestore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Repository
{
    public class MovieActorRepository : IMovieActorRepository
    {
        private readonly DataContext _context;

        public MovieActorRepository(DataContext context)
        {
            this._context = context;
        }

        public void AddMovieActors(Actor actor, Movie movie)
        {
            var movieActor = new MovieActor { MovieID = movie.Id, ActorID = actor.Id };
            _context.MovieActors.Add(movieActor);
            _context.SaveChanges();

        }

        public void DeleteMovieActors(MovieActor movieActor)
        {
            _context.MovieActors.Add(movieActor);
            _context.SaveChanges();
        }
    }
}
