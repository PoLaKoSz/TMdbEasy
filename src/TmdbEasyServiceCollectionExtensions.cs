using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using TmdbEasy.Configurations;
using TmdbEasy.Interfaces;

namespace TmdbEasy
{
    public static class TmdbEasyServiceCollectionExtensions
    {
        public static IServiceCollection AddTmdbEasy(this IServiceCollection serviceCollection, TmdbEasyOptions options)
        {
            var jsonDeserializer = new NewtonSoftDeserializer();
            var tmdbClient =  new TmdbEasyClientv3(options, jsonDeserializer);

            var sessionDescriptor = new ServiceDescriptor(
                    typeof(ITmdbEasyClient), c =>
                    {
                        return tmdbClient;
                    }, ServiceLifetime.Singleton);

            serviceCollection.TryAdd(sessionDescriptor);

            serviceCollection.AddSingleton<IReviewApi>(_ => tmdbClient.Review);
            serviceCollection.AddSingleton<IChangesApi>(_ => tmdbClient.Changes);
            serviceCollection.AddSingleton<ICompaniesApi>(_ => tmdbClient.Companies);
            serviceCollection.AddSingleton<ICollectionApi>(_ => tmdbClient.Collection);
            serviceCollection.AddSingleton<IConfigApi>(_ => tmdbClient.Config);
            serviceCollection.AddSingleton<ICreditApi>(_ => tmdbClient.Credit);
            serviceCollection.AddSingleton<IMovieApi>(_ => tmdbClient.Movie);
            serviceCollection.AddSingleton<INetworksApi>(_ => tmdbClient.Networks);
            serviceCollection.AddSingleton<ITelevisionApi>(_ => tmdbClient.Television);

            return serviceCollection;
        }
    }
}
