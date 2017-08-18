using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using VideoService.Models;
using VideoService.Providers;

namespace VideoService.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
        IMovieProvider _movieProvider;

        public MovieController(IMovieProvider movieProvider)
        {
            _movieProvider = movieProvider;
        }

        [HttpGet]
        public IEnumerable<MovieModel> Get()
        {
            return _movieProvider.GetMovies();
        }
    }
}
