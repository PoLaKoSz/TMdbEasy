using NUnit.Framework;
using System.Threading.Tasks;
using TmdbEasy.DTO.Reviews;
using TmdbEasy.Tests.Integration.TestFixtures;
using TmdbEasy.Interfaces;

namespace TmdbEasy.Tests.Integration
{
    [TestFixture]
    [Category("ReviewApi")]
    public class ReviewApiTest : TestBaseForV3
    {
        [TestCase("5488c29bc3a3686f4a00004a")]
        public async Task GetDetailsAsync_WithUserApiKey_ExistingId_ReturnsReview(string reviewId)
        {
            string userApiKey = GetApiKey();

            IReviewApi apiUnderTest = _clientWithApiKey.Review;

            Review result = await apiUnderTest.GetReviewDetailsAsync(reviewId, userApiKey);

            Assert.IsNotNull(result);
            Assert.AreEqual(reviewId, result.Id);
        }

        [TestCase("5488c29bc3a3686f4a00004a")]
        public async Task GetDetailsAsync_WithSharedApiKey_ExistingId_ReturnsReview(string reviewId)
        {
            string sharedApiKey = GetApiKey();

            IReviewApi apiUnderTest = _clientWithNoApiKey.Review;

            Review result = await apiUnderTest.GetReviewDetailsAsync(reviewId, sharedApiKey);

            Assert.IsNotNull(result);
            Assert.AreEqual(reviewId, result.Id);
        }
    }
}
