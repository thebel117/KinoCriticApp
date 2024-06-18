using KinoCritic.Data.Entities;
using KinoCritic.Services;
using Microsoft.AspNetCore.Mvc;

namespace KinoCritic.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingsController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet]
        public IActionResult GetAllRatings()
        {
            return Ok(_ratingService.GetAllRatings());
        }

        [HttpGet("{id}")]
        public IActionResult GetRatingById(int id)
        {
            return Ok(_ratingService.GetRatingById(id));
        }

        [HttpPost]
        public IActionResult CreateRating([FromBody] Rating rating)
        {
            _ratingService.CreateRating(rating);
            return CreatedAtAction(nameof(GetRatingById), new { id = rating.Id }, rating);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateRating(int id, [FromBody] Rating rating)
        {
            if (id != rating.Id)
            {
                return BadRequest();
            }
            _ratingService.UpdateRating(rating);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRating(int id)
        {
            _ratingService.DeleteRating(id);
            return NoContent();
        }
    }
}
