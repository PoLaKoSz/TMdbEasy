using System;
using System.Net.Http;
using System.Threading.Tasks;
using TmdbEasy.Configurations;
using TmdbEasy.Constants;
using TmdbEasy.Interfaces;

namespace TmdbEasy
{
    public class TmdbEasyClientv3 : ITmdbEasyClient
    {
        private readonly IJsonDeserializer _jsonDeserializer;
        private readonly TmdbEasyOptions _options;
        private readonly HttpClient _httpClient;

        public TmdbEasyClientv3(IJsonDeserializer jsonDeserializer, TmdbEasyOptions options)
        {
            _jsonDeserializer = jsonDeserializer;

            _options = options ?? throw new ArgumentNullException($"{nameof(TmdbEasyOptions)}");

            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri(GetUrl())
            };
        }

        /// <summary>
        /// Sends a request and parses to an object.
        /// </summary>
        /// <param name="query">Reletive path.</param>
        /// <typeparam name="TmdbEasyModel">Wanted deserialized object.</typeparam>
        /// <throws cref="ArgumentException">Occurs when invalid API key or query used.</throws>
        public async Task<TmdbEasyModel> GetResponseAsync<TmdbEasyModel>(string query)
        {
            if (string.IsNullOrEmpty(query) || string.IsNullOrWhiteSpace(query))
                throw new ArgumentException($"{nameof(TmdbEasyClientv3)} query param null or empty");

            if (string.IsNullOrEmpty(_options.ApiKey))
                throw new ArgumentException("A valid API key is required in order to make requests to the TMDB API!");

            query = FormatWithApiKey(query);

            var jsonResult = await _httpClient.GetStringAsync(query);

            return _jsonDeserializer.DeserializeTo<TmdbEasyModel>(jsonResult);
        }

        private string FormatWithApiKey(string query)
        {
            if (query.Contains("?"))
            {
                return $"{query}&api_key={_options.ApiKey}";
            }

            return $"{query}?api_key={_options.ApiKey}";
        }

        public ApiVersion GetVersion() => ApiVersion.v3;

        public string GetBaseUrl() => _httpClient.BaseAddress.ToString();

        private string GetUrl()
        {
            return _options.UseSsl ? UrlConstants.TmdbUrl3Ssl : UrlConstants.TmdbUrl3;
        }
    }
}
