using System.Threading.Tasks;
using TmdbEasy.DTO.Changes;
using TmdbEasy.DTO;

namespace TmdbEasy.Interfaces
{
    public interface IChangesApi
    {
        Task<ChangeList> GetChangeListAsync(ChangeListRequest changeListRequest);
    }
}
