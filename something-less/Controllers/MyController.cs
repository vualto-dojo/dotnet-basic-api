using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using something_less.Models;

namespace something_less.Controllers
{
    [Route("api/[controller]")]
    public class MyController : ControllerBase
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

        [HttpPost]
        [Route("set")]
        public IActionResult SetId([FromBody] VuClass bar )
        {
            return Ok($"something {bar.Foo}");
        }



    }
}
