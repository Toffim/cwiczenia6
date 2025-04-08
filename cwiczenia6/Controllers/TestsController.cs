using cwiczenia6.Models;
using Microsoft.AspNetCore.Mvc;

namespace cwiczenia6.Controllers
{
    // api/tests => [controller] = Tests
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        // GET api/tests
        [HttpGet]
        public IActionResult Get()
        {
            var tests = Database.Tests;
            return Ok(tests);
        }
        
        // GET api/tests/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var test = Database.Tests.FirstOrDefault(t => t.Id == id);
            return Ok(test);
        }

        // POST api/tests
        [HttpPost]
        public IActionResult Add(Test test)
        {
            Database.Tests.Add(test);
            return Created();
        }
        
        // PUT api/tests/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, Test test)
        {
            Database.Tests[id] = test;
            return Created();
        }
    }
}