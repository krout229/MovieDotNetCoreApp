using MovieDotNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDotNetCore.DAL.Repositories
{
    class MovieRepository : IMovieRepository
    {
        public string DeleteMovie(int MovieId)
        {
            return "Deleted";
        }

        public List<MovieDetails> GetAllMovies()
        {
          return new List<MovieDetails>();
        }

        public MovieDetails GetMovie(int MovieId)
        {
            MovieDetails movieDetails=new MovieDetails();
            return movieDetails;
        }

        public string SaveMovie(MovieDetails movieDetails)
        {
            return "Saved";
        }

        public string UpdateMovie(MovieDetails movieDetails)
        {
            return "Updated";
        }
    }
}
