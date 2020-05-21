using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Required]
        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        [Display(Name = "Release Date")]
        public Nullable<DateTime> ReleaseDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public Nullable<DateTime> DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        public int NumberAvailable { get; set; }

    }

    // /movies/random


}