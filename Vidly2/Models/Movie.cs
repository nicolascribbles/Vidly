using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Vidly2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

        public Nullable<DateTime> ReleaseDate { get; set; }

        public Nullable<DateTime> DateAdded { get; set; }

        public int NumberAvailable { get; set; }

    }

    // /movies/random


}