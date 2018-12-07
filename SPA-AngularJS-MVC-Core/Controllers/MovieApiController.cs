using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SPA_AngularJS_MVC_Core.Controllers
{
    [Produces("application/json")]
    [Route("api/MovieApi")]
    public class MovieApiController : Controller
    {
        IMovieRepo _movieRepo;
        public MovieApiController(IMovieRepo repo)
        {
            _movieRepo = repo;
        }

        // GET: api/MovieApi
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _movieRepo.GetMovies();
        }

        // GET: api/MovieApi/5
        [HttpGet("{id}", Name = "Get")]
        public Movie Get(int id)
        {
            return _movieRepo.GetMovie(id);
        }

        // POST: api/MovieApi
        [HttpPost]
        public void Post([FromBody]Movie model)
        {
            _movieRepo.CreateMovie(model);
        }

        // PUT: api/MovieApi/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Movie model)
        {
            model.Id = id;
            _movieRepo.UpdateMovie(model);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _movieRepo.DeleteMovie(id);
        }

        //[HttpGet]
        //[Route("[action]/{id}")]
        //public string GetValues(int id)
        //{
        //    return "Ok";
        //}
    }
}
