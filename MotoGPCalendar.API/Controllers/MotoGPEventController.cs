using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MotoGPCalendar.Business.Handlers;
using System.Threading.Tasks;

namespace MotoGPCalendar.API.Controllers
{
    [Produces("application/json")]
    [Route("api/events")]
    [ApiController]
    public class MotoGPEventController : ControllerBase
    {
        private MotoGPEventHandler _handler;
        public MotoGPEventController(MotoGPEventHandler handler)
        {
            _handler = handler;
        }
        /// <summary>
        /// Provides a JSON with all the MotoGP events and their basic data.
        /// </summary>
        /// <returns>JSON with all the events and their basic data.</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> GetAsync()
        {
            return new JsonResult(await _handler.GetAllAsync());

        }
        /// <summary>
        /// Provides JSON with detailed data about the given event.
        /// </summary>
        /// <param name="id">The id of the event.</param>
        /// <returns>JSON with detailed data about the given event.</returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<string>> Get(int id)
        {
            return new JsonResult(await _handler.GetByIdAsync(id));
        }
    }
}
