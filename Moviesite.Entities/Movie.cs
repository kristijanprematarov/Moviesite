using Bookstore.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Moviesite.Entities
{
    public class Movie
    {
        [Key]

        public int Id { get; set; }

        [StringLength(350)]
        public string Title { get; set; }

        public string ProducerName { get; set; }
        public int ProducerID { get; set; }
        public Producer Producer { get; set; }
        public DateTime YearFilmed { get; set; }
        public string Duration { get; set; }

        public int UserId { get; set; }

        [StringLength(150)]
        public string Genre { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [StringLength(150)]
        public string CategoryName { get; set; }

        public double Price { get; set; }

        [StringLength(50)]
        public string FormatType { get; set; } //Mp4,WMA,BluRay,H-264,H-265

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(50)]

        public string Language { get; set; }

        [StringLength(150)]

        public string Country { get; set; }

        [StringLength(50)]

        public string Shipping { get; set; }

        public string PhotoURL { get; set; } // za cover slikata !!!

        public int SoldItems { get; set; }

        public double Rating { get; set; }

        public DateTime DateAdded { get; set; }

        //public ICollection<Photo> Photos { get; set; }
    }
}
