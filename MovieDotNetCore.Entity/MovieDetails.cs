using System;

namespace MovieDotNetCore.Entity
{
    public class MovieDetails
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public string Director { get; set; }
        public int Price { get; set; }
    }
}
