using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Moviesite.Entities
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        public DateTime DateBirth { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
