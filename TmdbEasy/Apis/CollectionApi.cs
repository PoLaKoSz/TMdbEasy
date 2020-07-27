using System.Threading.Tasks;
using TmdbEasy.Constants;
using TmdbEasy.DTO;
using TmdbEasy.DTO.Images;
using TmdbEasy.DTO.Other;
using TmdbEasy.Interfaces;

namespace TmdbEasy.Apis
{
    public class CollectionApi : ICollectionApi
    {
        private readonly ITmdbEasyClient _client;

        public CollectionApi(ITmdbEasyClient client)
        {
            _client = client;
        }

        public async Task<Collections> GetDetailsAsync(IdRequest request, string language = "en")
        {
            string queryString = $"collection/{request.Id}?language={language}";

            return await _client.GetResponseAsync<Collections>(queryString).ConfigureAwait(false);
        }

        public async Task<Images> GetImagesAsync(IdRequest request, string language = "en")
        {
            string queryString = $"collection/{request.Id}/images?language={language}";

            return await _client.GetResponseAsync<Images>(queryString).ConfigureAwait(false);
        }
    }
}
