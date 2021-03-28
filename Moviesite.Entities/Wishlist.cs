using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Moviesite.Entities
{
    public class Wishlist
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; } //vo Identity userot e GUID pa zatoa odime so string

        public int MovieId { get; set; }

        public int AuthorId { get; set; }

        public int CategoryId { get; set; }

        public DateTime DateAdded { get; set; }//koga? ni e staveno vo wishlist
    }
}
