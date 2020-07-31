using System.Threading.Tasks;
using TmdbEasy.DTO.Other;
using TmdbEasy.Interfaces;

namespace TmdbEasy.Apis
{
    internal class NetworksApi : INetworksApi
    {
        private readonly RequestHandler _requestHandler;

        internal NetworksApi(RequestHandler requestHandler)
        {
            _requestHandler = requestHandler;
        }

        public async Task<Network> GetDetailsAsync(int networkId, string userApiKey)
        {
            var restRequest = _requestHandler
             .CreateRequest()
             .AddUrlSegment("network")
             .AddUrlSegment($"{networkId}")
             .AddApiKey(userApiKey);

            return await _requestHandler.ExecuteAsync<Network>(restRequest);
        }
    }
}
