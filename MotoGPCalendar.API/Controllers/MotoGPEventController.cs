using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MotoGPCalendar.Business.Services;
using System.Threading.Tasks;
using MotoGPCalendar.DTOs;

namespace MotoGPCalendar.API.Controllers
{
    [Produces("application/json")]
    [Route("api/events")]
    [ApiController]
    public class MotoGPEventController : ControllerBase
    {
        private MotoGPEventService _service;
        public MotoGPEventController(MotoGPEventService service)
        {
            _service = service;
        }
        /// <summary>
        /// Provides a JSON with all the MotoGP events and their basic data.
        /// </summary>
        /// <returns>JSON with all the events and their basic data.</returns>
        [HttpGet]
        public async Task<IEnumerable<EventDTO>> GetAsync()
        {
            return await _service.GetAllAsync();

        }
        /// <summary>
        /// Provides JSON with detailed data about the given event.
        /// </summary>
        /// <param name="id">The id of the event.</param>
        /// <returns>JSON with detailed data about the given event.</returns>
        [HttpGet("{id}")]
        public async Task<EventDetailsDTO> Get(int id)
        {
            return await _service.GetByIdAsync(id);
        }
    }
}
