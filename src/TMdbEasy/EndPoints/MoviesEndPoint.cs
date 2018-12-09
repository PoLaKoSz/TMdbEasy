using Newtonsoft.Json;
using System.Threading.Tasks;
using TMdbEasy.Models;
using TMdbEasy.TmdbObjects.Movies;

namespace TMdbEasy.EndPoints
{
    public class MoviesEndPoint : BaseSecureEndPoint, IMoviesEndPoint
    {
        public MoviesEndPoint()
            : base("movie") { }



        public async Task<Movie> Get()
        {
            string response = await base.CallApi();

            return JsonConvert.DeserializeObject<Movie>(response);
        }

        public async Task<MovieAccountState> GetAccountState()
        {
            string response = await base.CallApi();

            return JsonConvert.DeserializeObject<MovieAccountState>(response);
        }
    }
}
