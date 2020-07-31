



using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TmdbEasy.DTO.Movies;
using TmdbEasy.Interfaces;

namespace TmdbEasySamples.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TmdbController : ControllerBase
    {
        private readonly IMovieApi _movieApi;

        public TmdbController(IMovieApi movieApi)
        {
            _movieApi = movieApi;
        }

        [HttpGet]
        public Task<MovieList> Get()
        {
            return _movieApi.SearchMoviesAsync("Harry Potter");
        }
    }
}
