using MovieDotNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using MovieDotNetCore.DAL.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            string msg = "";
            MovieDetails deleteMovie = _movieDbContext.movieDetails.Find(MovieId);//storing the details of the movie in the obj 
            if (deleteMovie != null)
            {
                _movieDbContext.movieDetails.Remove(deleteMovie);
                _movieDbContext.SaveChanges();
                msg = "Deleted";
            }
            return msg;
        }

        public List<MovieDetails> GetAllMovies()
        {
            List < MovieDetails > movieDetails= _movieDbContext.movieDetails.ToList();
          return movieDetails;
        }

        public MovieDetails GetMovie(int MovieId)
        {
            MovieDetails movieDetails=_movieDbContext.movieDetails.Find(MovieId);
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
            
            _movieDbContext.Entry(movieDetails).State = EntityState.Modified;
            _movieDbContext.SaveChanges();
            return "Updated";
        }
    }
}
