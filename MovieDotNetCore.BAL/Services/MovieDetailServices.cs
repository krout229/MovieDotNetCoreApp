using System;
using System.Collections.Generic;
using System.Text;
using MovieDotNetCore.DAL.Repositories;
using MovieDotNetCore.Entity;
namespace MovieDotNetCore.BAL.Services
{
    public class MovieDetailServices
    {
        private IMovieRepository _movieRepository;
        public MovieDetailServices(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public string SaveMovie(MovieDetails movieDetails)
        {
            return _movieRepository.SaveMovie(movieDetails);
        }
    }
}
