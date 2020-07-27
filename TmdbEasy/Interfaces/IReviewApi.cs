using System.Threading.Tasks;
using TmdbEasy.DTO;
using TmdbEasy.DTO.Reviews;

namespace TmdbEasy.Interfaces
{
    public interface IReviewApi
    {
        Task<Review> GetReviewDetailsAsync(ReviewRequest request);
    }
}
