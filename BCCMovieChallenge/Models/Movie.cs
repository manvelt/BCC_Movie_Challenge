using System;
using Microsoft.AspNetCore.Http;

namespace BCCMovieChallenge.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }

        public Movie()
        {
        }
    }
}
