using System;
using System.Net.Http;
using TmdbEasy.Apis;
using TmdbEasy.Configurations;
using TmdbEasy.Interfaces;

namespace TmdbEasy
{
    public class TmdbEasyClientv3 : ITmdbEasyClientv3, ITmdbEasyClient
    {
        private static readonly  string _tmdbUrl3 = "http://api.themoviedb.org/3/";
        private static readonly string _tmdbUrl3Ssl = "https://api.themoviedb.org/3/";

        public TmdbEasyClientv3(TmdbEasyOptions options)
            : this(options, new NewtonSoftDeserializer())
        {
        }

        public TmdbEasyClientv3(TmdbEasyOptions options, IJsonDeserializer jsonDeserializer)
        {
            Options = options ?? throw new ArgumentNullException(nameof(options));

            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri(Options.UseSsl ? _tmdbUrl3Ssl : _tmdbUrl3)
            };

            var requestHandler = new RequestHandler(Options, httpClient, jsonDeserializer);

            Changes = new ChangesApi(requestHandler);
            Collection = new CollectionApi(requestHandler);
            Companies = new CompaniesApi(requestHandler);
            Config = new ConfigApi(requestHandler);
            Credit = new CreditApi(requestHandler);
            Movie = new MovieApi(requestHandler);
            Networks = new NetworksApi(requestHandler);
            Review = new ReviewApi(requestHandler);
            Television = new TelevisionApi(requestHandler);
        }

        public IChangesApi Changes { get; }
        public ICollectionApi Collection { get; }
        public ICompaniesApi Companies { get; }
        public IConfigApi Config { get; }
        public ICreditApi Credit { get; }
        public IMovieApi Movie { get; }
        public INetworksApi Networks { get; }
        public IReviewApi Review { get; }
        public ITelevisionApi Television { get; }

        public TmdbEasyOptions Options { get; }
        public HttpClient HttpClient  { get; }
        public IJsonDeserializer JsonDeserializer  { get; }
    }
}
