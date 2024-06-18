using KinoCritic.Data.Entities;
using KinoCritic.Services;
using Microsoft.AspNetCore.Mvc;

namespace KinoCritic.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetAllMovies()
        {
            return Ok(_movieService.GetAllMovies());
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            return Ok(_movieService.GetMovieById(id));
        }

        [HttpPost]
        public IActionResult CreateMovie([FromBody] Movie movie)
        {
            _movieService.CreateMovie(movie);
            return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovie(int id, [FromBody] Movie movie)
        {
            if (id != movie.Id)
            {
                return BadRequest();
            }
            _movieService.UpdateMovie(movie);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            _movieService.DeleteMovie(id);
            return NoContent();
        }
    }
}
