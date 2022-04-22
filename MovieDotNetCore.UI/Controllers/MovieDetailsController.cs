using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MovieDotNetCore.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace MovieDotNetCore.UI.Controllers
{
    public class MovieDetailsController : Controller
    {
        private IConfiguration _configuration;
        public MovieDetailsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SaveMovie()
        {
            return View();
        }
        public IActionResult GetMovie()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SaveMovie(MovieDetails movieDetails)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(movieDetails), Encoding.UTF8, "application/json");
                string endPoint = _configuration["WebApiBaseUrl"] + "MovieDetails/SaveMovie";
                using (var response = await client.PostAsync(endPoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Movie details saved successfully!";
                    }
                    else
                    {
                        ViewBag.status = "Error";
                        ViewBag.message = "Wrong entries!";
                    }
                }
            }
            return View();
        }
    }
}

