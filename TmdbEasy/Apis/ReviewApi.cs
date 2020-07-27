using System.Threading.Tasks;
using TmdbEasy.Constants;
using TmdbEasy.DTO;
using TmdbEasy.DTO.Reviews;
using TmdbEasy.Interfaces;

namespace TmdbEasy.Apis
{
    public class ReviewApi : IReviewApi
    {
        private readonly ITmdbEasyClient _client;

        public ReviewApi(ITmdbEasyClient client)
        {
            _client = client;
        }

        public async Task<Review> GetReviewDetailsAsync(ReviewRequest request)
        {
            string queryString = $"review/{request.Id}?";

            return await _client.GetResponseAsync<Review>(queryString).ConfigureAwait(false);
        }
    }
}
