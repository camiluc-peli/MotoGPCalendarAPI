using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using MotoGPCalendar.Business.Handlers;

namespace MotoGPCalendar.API.Controllers
{
    [Route("api/events")]
    [ApiController]
    public class MotoGPEventController : ControllerBase
    {
        private MotoGPEventHandler _handler;
        public MotoGPEventController(MotoGPEventHandler handler)
        {
            _handler = handler;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new JsonResult(_handler.GetAll());

        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return new JsonResult(_handler.GetById(id));
        }
    }
}
