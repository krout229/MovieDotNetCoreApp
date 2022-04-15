using MovieDotNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using MovieDotNetCore.DAL.Data;


namespace MovieDotNetCore.DAL.Repositories
{
   public class MovieRepository : IMovieRepository
    {
        private MovieDbContext _movieDbContext;
        public MovieRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }
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
            //works as insert into
            _movieDbContext.movieDetails.Add(movieDetails);
            _movieDbContext.SaveChanges();
            return "Saved";
        }

        public string UpdateMovie(MovieDetails movieDetails)
        {
            return "Updated";
        }
    }
}
