using System.Threading.Tasks;
using TMdbEasy.TmdbObjects.Other;

namespace TMdbEasy.ApiInterfaces
{
    public interface IReviewApi : IBase
    {
        /// <summary>
        /// Get the reviews for a specific review id
        /// </summary>
        /// <param name="id">Typically taken from a previous api call</param>       
        /// <returns></returns>
        Task<Reviews> GetDetailsAsync(int id);
    }
}
