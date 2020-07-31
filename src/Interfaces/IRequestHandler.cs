using System.Threading.Tasks;

namespace TmdbEasy.Interfaces
{
    public interface RequestHandler
    {
        Request CreateRequest();

        Task<TmdbEasyModel> ExecuteAsync<TmdbEasyModel>(Request request);
    }
}
