using System.Collections.Generic;
using VideoService.Models;

namespace VideoService.Providers
{
    public interface IMovieProvider
    {
        IEnumerable<MovieModel> GetMovies();
    }
}
