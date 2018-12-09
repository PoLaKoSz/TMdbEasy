using System.Threading.Tasks;
using TMdbEasy.ApiInterfaces;
using static TMdbEasy.REngine;
using TMdbEasy.TmdbObjects.Other;

namespace TMdbEasy.ApiObjects
{
    internal class NetworksApi : INetworksApi
    {
        public async Task<Network> GetDetailsAsync(int id)
        {
            var content = await CallApiAsync($"{Url}review/{id}?api_key={ApiKey}").ConfigureAwait(false);
            return DeserializeJson<Network>(content);
        }
    }
}
