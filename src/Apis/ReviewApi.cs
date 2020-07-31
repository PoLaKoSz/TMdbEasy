using System.Threading.Tasks;
using TmdbEasy.DTO.Reviews;
using TmdbEasy.Interfaces;

namespace TmdbEasy.Apis
{
    internal class ReviewApi : IReviewApi
    {
        private readonly RequestHandler _requestHandler;

        internal ReviewApi(RequestHandler requestHandler)
        {
            _requestHandler = requestHandler;
        }

        public async Task<Review> GetReviewDetailsAsync(string reviewId, string apiKey = null)
        {
            var restRequest = _requestHandler
                .CreateRequest()
                .AddUrlSegment($"review/{reviewId}")
                .AddApiKey(apiKey);

            return await _requestHandler.ExecuteAsync<Review>(restRequest);
        }
    }
}
