using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302204058.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        // membuat array of string yang berisi data movie
        private static List<Movie> listMovies = new List<Movie>()
        {
            new Movie("The Shawshank Redemption", "Frank Darabont", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency."),
            new Movie("The Godfather", "Francis Ford Coppola", "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie("The Darknight", "Christopher Nolan", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
        };

        // GET: api/Movie
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return listMovies;
        }

        // GET api/Movie/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return listMovies[id];
        }

        // POST api/Movie
        [HttpPost]
        public void Post([FromBody] Movie value)
        {
            listMovies.Add(value);
        }

        // DELETE api/Movie/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            listMovies.RemoveAt(id);
        }
    }
}
