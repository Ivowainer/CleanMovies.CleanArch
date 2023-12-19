using CleanMovie.Application.Services;
using CleanMovie.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("[controller]")]
    public class MoviesController : Controller
    {
        private readonly IMovieService _movieService;
        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public ActionResult<List<Movie>> GetMovies()
        {
            return Ok(_movieService.GetAllMovies());
        }

        [HttpPost]
        public ActionResult<Movie> PostMovie(Movie movie)
        {
            return Ok(_movieService.CreateMovie(movie));
        }
    }
}