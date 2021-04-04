using Moviesite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moviesite.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Movie> AllMoviesList { get; set; }
    }
}
