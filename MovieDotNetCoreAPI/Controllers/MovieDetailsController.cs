using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieDotNetCore.BAL.Services;
using MovieDotNetCore.Entity;

namespace MovieDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieDetailsController : ControllerBase
    {
        private MovieDetailServices _movieDetailsServices;
        public MovieDetailsController(MovieDetailServices movieDetailServices)
        {
            _movieDetailsServices = movieDetailServices;
        }
        [HttpPost("SaveMovie")]
        public IActionResult SaveMovie(MovieDetails movieDetails)
        {
            return Ok(_movieDetailsServices.SaveMovie(movieDetails));
        }

        [HttpPost("DeleteMovies")]
        public IActionResult DeleteMovie(int MovieId)
        {
            return Ok(_movieDetailsServices.DeleteMovie(MovieId));
        }

        [HttpPost("UpdateMovie")]
        public IActionResult UpdateMovie(MovieDetails movieDetails)
        {
            return Ok(_movieDetailsServices.UpdateMovie(movieDetails));
        }

        [HttpGet("GetMovie")]
        public IActionResult GetMovie(int MovieId)
        {
            return Ok(_movieDetailsServices.GetMovie(MovieId));
        }

        [HttpGet("GetAllMovies")]
        public List<MovieDetails> GetAllMovies()
        {
            return _movieDetailsServices.GetAllMovies();
        }
    }
}
