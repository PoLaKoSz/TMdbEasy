using Newtonsoft.Json;
using System.Threading.Tasks;
using TMdbEasy.TmdbObjects.Other;

namespace TMdbEasy.EndPoints
{
    public class ReviewsEndPoint : BaseSecureEndPoint, IReviewsEndPoint
    {
        public ReviewsEndPoint()
            : base("review") { }



        public async Task<Reviews> Get()
        {
            string response = await base.CallApi();

            return JsonConvert.DeserializeObject<Reviews>(response);
        }
    }
}
