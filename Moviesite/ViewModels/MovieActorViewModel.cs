using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviesite.ViewModels
{
    public class MovieActorViewModel
    {
        public IEnumerable<Actor> Actors { get; set; }

        public Movie Movie { get; set; }
    }
}
