using Microsoft.AspNetCore.Mvc;
using something.less.api.Models;

namespace something.less.api.Controllers
{
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "something less.";
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetId(int id)
        {
            if (id > 10) return NotFound();
            this.BadRequest();
            return StatusCode(502, $"something more: {id}");
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult SetId([FromBody] VuClass vuClass)
        {
            return Ok($"something {vuClass.Foo}");
        }
    }
}
