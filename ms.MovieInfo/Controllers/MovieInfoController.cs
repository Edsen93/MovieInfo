using ms.MovieInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ms.MovieInfo.Controllers
{
    public class MovieInfoController : ApiController
    {
        // GET: api/MovieInfo
        // FIND ALL MOVIES
        public IEnumerable<Movie> Get()
        {
            Movie m = new Movie();
            Movie m1 = new Movie();

            m.ID = 1;
            m.title = "Star wars";
            m.genres = "bob";

            m1.ID = 2;
            m1.title = "Star trek";
            m1.genres = "lol";

            return new Movie[] { m, m1 };
        }

        // GET: api/MovieInfo/5
        public Movie Get(int id)
        {
            MoviePersistence mp = new MoviePersistence();
            mp.findOneMovie(id);
        }

        // POST: api/MovieInfo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MovieInfo/5
        public void Put(int id, [FromBody]Movie value)
        {
            MoviePersistence mp = new MoviePersistence();
            mp.updateMovie(id, value);
            
        }

        // DELETE: api/MovieInfo/5
        public void Delete(int id)
        {
            MoviePersistence mp = new MoviePersistence();
            mp.deleteMovie(id);
        }
    }
}
