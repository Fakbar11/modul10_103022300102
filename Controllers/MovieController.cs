using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace jurnal10.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movie = new()
        {
            new Movie ( "The Godfather", "Francis Ford Coppola", new List<string> { "Marlon Brando", "Al Pacino", "James Caan" }, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son." ),
            new Movie ( "The Dark Knight", "Christopher Nolan", new List<string> { "Christian Bale", "Heath Ledger", "Aaron Eckhart" }, "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness." ),
            new Movie ( "12 Angry Men", "Sidney Lumet", new List<string> { "Martin Balsam", "John Fiedler", "Lee J. Cobb" }, "The jury in a New York City murder trial is frustrated by a single member whose skeptical caution forces them to more carefully consider the evidence before jumping to a hasty verdict." ),
        };

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return Ok(movie);
        }

        [HttpGet("{id}")]
        public ActionResult<Movie> Get(int id)
        {
            if (id < 0 || id >= movie.Count)
            {
                return NotFound();
            }
            return movie[id];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Movie movies)
        {
            movie.Add(movies);
            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (id < 0 || id >= movie.Count)
            {
                return NotFound();
            }
            movie.RemoveAt(id);
            return Ok(movie);
        }
    }
}
