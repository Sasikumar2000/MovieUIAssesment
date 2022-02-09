using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieWebsite.Model;



namespace MovieWebsite.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieDbContext _movieDbContext;
        public MovieController(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;
        }

        [HttpGet("GetTutorials")]
        public IEnumerable<MovieProperty> GetTutorials()
        {
            return _movieDbContext.movieProperty.ToList();
        }

        [HttpGet("MovieById")]
        public MovieProperty MovieById(int MovieId)
        {
            return _movieDbContext.movieProperty.Find(MovieId);
        }

        [HttpPost("AddMovie")]
        public IActionResult AddMovie([FromBody]MovieProperty Movie)
        {
            if (Movie.MovieId.ToString() != "")
            {
               
                _movieDbContext.movieProperty.Add(Movie);
                _movieDbContext.SaveChanges();
                return Ok("Successfully Added");                
            }
            else
            {
                return BadRequest(); 

            }
        }

        [HttpPut("UpdateMovie")]
        public IActionResult UpdateMovie([FromBody] MovieProperty Movie)
        {
            if (Movie.MovieId.ToString() != "")
            {
                
                _movieDbContext.Entry(Movie).State = EntityState.Modified;
                _movieDbContext.SaveChanges();
                return Ok("Successfully Updated ");
            }
            else
            {
                return BadRequest();

            }
        }

       [HttpDelete("DeleteMovie")]
        public IActionResult DeleteMovie(int MovieId)
        {
        var result = _movieDbContext.movieProperty.Find(MovieId);
        _movieDbContext.movieProperty.Remove(result);
        _movieDbContext.SaveChanges();
        return Ok("Deleted Successfully");



        }
    }
}

