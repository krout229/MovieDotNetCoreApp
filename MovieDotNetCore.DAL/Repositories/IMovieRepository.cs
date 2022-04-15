using MovieDotNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieDotNetCore.DAL.Repositories
{
   public interface IMovieRepository
    {
        public string SaveMovie(MovieDetails movieDetails);
        public string UpdateMovie(MovieDetails movieDetails);
        public string DeleteMovie(int MovieId);
        MovieDetails GetMovie(int MovieId);
        List<MovieDetails> GetAllMovies(); //list returns more than one record

    }
}
