using System.Threading.Tasks;
using TmdbEasy.Configurations;

namespace TmdbEasy.Interfaces
{
    public interface ITmdbEasyClientv3
    {
        IChangesApi Changes { get; }
        ICollectionApi Collection { get; }
        ICompaniesApi Companies { get; }
        IConfigApi Config { get; }
        ICreditApi Credit { get; }
        IMovieApi Movie { get; }
        INetworksApi Networks { get; }
        IReviewApi Review { get; }
        ITelevisionApi Television { get; }
    }
}
