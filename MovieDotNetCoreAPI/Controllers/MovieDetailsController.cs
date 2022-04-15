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
        [HttpPost]
        public IActionResult SaveMovie(MovieDetails movieDetails)
        {
            return Ok(_movieDetailsServices.SaveMovie(movieDetails));
        }
    }
}
