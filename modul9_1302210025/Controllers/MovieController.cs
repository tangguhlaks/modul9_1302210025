using Microsoft.AspNetCore.Mvc;

namespace modul9_1302210025.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie(1,"The super mario bros","Aaron Horvath","The story of The Super Mario Bros. on their journey through the Mushroom Kingdom."
                ,new List<string>
                {
                    "Chris Pratt","Anya Taylor","JoyCharlie Day"
                }),
            new Movie(2,"Puss in Boots","Joel Crawford","When Puss in Boots discovers that his passion for adventure has taken its toll and he has burned through eight of his nine lives, he launches an epic journey to restore them by finding the mythical Last Wish.",
                new List<string>
                {
                    "Antonio Banderas","Salma Hayek"
                }),
            new Movie(3,"Jhon Wick : Chaper 4","Chad Sathelski","John Wick uncovers a path to defeating The High Table. But before he can earn his freedom, Wick must face off against a new enemy with powerful alliances across the globe and forces that turn old friends into foes.",
                new List<string>
                {
                    "Keanu Reeves","Laurence Fishburne"
                })
        };
 

        [Route("Movies")]
        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(movies);
        }

        [Route("Movies")]
        [HttpGet]
        public IActionResult GetMoviesById(int id)
        {
            var res = movies.Where(x=>x.id == id).First(); 
            return Ok(res);
        }

        [Route("Movies")]
        [HttpPost]
        public bool AddMovies([FromBody] Movie obj)
        {
            try
            {
                movies.Add(obj);
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }


        [Route("Movies")]
        [HttpDelete]
        public bool DeleteMovies(int id)
        {
            try
            {
                movies.Remove(movies.Where(x=>x.id ==id).First()); 
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
