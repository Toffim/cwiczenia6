using cwiczenia6.Models;
using Microsoft.AspNetCore.Mvc;

namespace cwiczenia6.Controllers
{
    // api/animals => [controller] = Animals
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        // GET api/animals
        [HttpGet]
        public IActionResult Get()
        {
            var animals = Database.Animals;
            return Ok(animals);
        }

        // GET api/animals/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var animal = Database.Animals.FirstOrDefault(t => t.Id == id);
            return Ok(animal);
        }

        // POST api/animals
        [HttpPost]
        public IActionResult Add(Animal animal)
        {
            Database.Animals.Add(animal);
            return Created();
        }

        // PUT api/animals/id
        // For editing an existing animal
        [HttpPut("{id}")]
        public IActionResult Put(int id, Animal updatedAnimal)
        {
            var existingAnimal = Database.Animals.FirstOrDefault(a => a.Id == id);
            if (existingAnimal == null)
            {
                return NotFound();
            }

            existingAnimal.Name = updatedAnimal.Name;
            existingAnimal.Category = updatedAnimal.Category;
            existingAnimal.Mass = updatedAnimal.Mass;
            existingAnimal.ColorFur = updatedAnimal.ColorFur;

            return Ok();
        }
    }
}