using KinoCritic.Data.Entities;
using KinoCritic.Services;
using Microsoft.AspNetCore.Mvc;

namespace KinoCritic.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShowsController : ControllerBase
    {
        private readonly IShowService _showService;

        public ShowsController(IShowService showService)
        {
            _showService = showService;
        }

        [HttpGet]
        public IActionResult GetAllShows()
        {
            return Ok(_showService.GetAllShows());
        }

        [HttpGet("{id}")]
        public IActionResult GetShowById(int id)
        {
            return Ok(_showService.GetShowById(id));
        }

        [HttpPost]
        public IActionResult CreateShow([FromBody] Show show)
        {
            _showService.CreateShow(show);
            return CreatedAtAction(nameof(GetShowById), new { id = show.Id }, show);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateShow(int id, [FromBody] Show show)
        {
            if (id != show.Id)
            {
                return BadRequest();
            }
            _showService.UpdateShow(show);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteShow(int id)
        {
            _showService.DeleteShow(id);
            return NoContent();
        }
    }
}
