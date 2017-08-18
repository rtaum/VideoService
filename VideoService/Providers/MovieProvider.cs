using System.Collections.Generic;
using VideoService.Models;

namespace VideoService.Providers
{
    public class MovieProvider : IMovieProvider
    {
        public IEnumerable<MovieModel> GetMovies()
        {
            return new MovieModel[]
{
                new MovieModel
                {
                    Id = "tt0121766",
                    Title = "Star Wars: Episode III - Revenge of the Sith",
                    Year = 2005,
                    Duration = 140
                },
                new MovieModel
                {
                    Id = "tt2130321",
                    Title = "West of Memphis",
                    Year = 2012,
                    Duration = 147
                },
                new MovieModel
                {
                    Id = "tt2557490",
                    Title = "A Million Ways to Die in the West",
                    Year = 2014,
                    Duration = 116
                }
};
        }
    }
}
