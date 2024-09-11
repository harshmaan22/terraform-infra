using Batch2024TrainingDemo.Contracts;
using Batch2024TrainingDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Batch2024TrainingDemo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {

        private readonly ILogger<MoviesController> _logger;
        private readonly IMovieService _movieService;

        public MoviesController(ILogger<MoviesController> logger, IMovieService movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }

        [HttpGet(Name = "Movies")]
        public List<Movie> GetMovies()
        {
            return _movieService.GetMovies();

        }

        [HttpPost(Name = "AddMovie")]
        public string AddMovie(Movie request)
        {
            return _movieService.AddMovie(request) ? "Movie Added":"Could not able to add new movie, Please try again";
        }
    }
}