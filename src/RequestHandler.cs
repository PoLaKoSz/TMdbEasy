using System;
using System.Net.Http;
using System.Threading.Tasks;
using TmdbEasy.Configurations;
using TmdbEasy.Interfaces;

namespace TmdbEasy
{
    internal class RequestHandler
    {
        private readonly HttpClient _httpClient;
        private readonly IJsonDeserializer _jsonDeserializer;
        private readonly TmdbEasyOptions _options;

        internal RequestHandler(ITmdbEasyClient client)
            :this(client.Options, client.HttpClient, client.JsonDeserializer)
        {
        }

        internal RequestHandler(
            TmdbEasyOptions options,
            HttpClient httpClient,
            IJsonDeserializer jsonDeserializer)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _options = options;
            _jsonDeserializer = jsonDeserializer;
        }

        internal Request CreateRequest()
        {
            return new Request(_options);
        }

        internal async Task<TmdbEasyModel> ExecuteAsync<TmdbEasyModel>(Request request)
        {
            string url = request.GetUri();
            if (string.IsNullOrEmpty(url) || string.IsNullOrWhiteSpace(url))
                throw new ArgumentException("Generated url is invalid (null or empty)!", nameof(request));

            string json = await _httpClient.GetStringAsync(url)
                .ConfigureAwait(false);

            return _jsonDeserializer.DeserializeTo<TmdbEasyModel>(json);
        }
    }
}
