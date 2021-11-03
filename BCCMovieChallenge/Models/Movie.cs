using System;
using System.ComponentModel.DataAnnotations;

namespace BCCMovieChallenge.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }

        public Movie()
        {
        }
    }
}
