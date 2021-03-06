namespace Moviesite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class MovieViewModel
    {
        [StringLength(350)]
        public string Title { get; set; }

        [Display(Name = "Producer")]
        public string ProducerName { get; set; }

        [Display(Name = "Producer")]
        public int ProducerID { get; set; }

        [Display(Name = "Director")]
        public string DirectorName { get; set; }

        [Display(Name = "Director")]
        public int DirectorID { get; set; }
        
        public int[] ActorIds { get; set; }

        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }
       
        public string Duration { get; set; }

        public int UserId { get; set; }

        [Display(Name = "Genre")]
        [StringLength(150)]
        public string GenreName { get; set; }

        [Display(Name = "Genre")]
        public int GenreID { get; set; }

        public double Price { get; set; }

        [Display(Name = "Format type")]
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

        [Display(Name = "Photo URL")]
        public string PhotoURL { get; set; } // za cover slikata !!!

        [Display(Name = "Sold items")]
        public int SoldItems { get; set; }

        public double Rating { get; set; }

        [Display(Name = "Date added")]
        public DateTime DateAdded { get; set; }
    }
}
