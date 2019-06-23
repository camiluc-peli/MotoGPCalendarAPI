using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MotoGPCalendar.Data.Repositories;

namespace MotoGPCalendar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoGPEventController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            throw new System.NotImplementedException();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            throw new System.NotImplementedException();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            throw new System.NotImplementedException();
        }
    }
}
