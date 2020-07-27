using NUnit.Framework;
using System.Threading.Tasks;
using TmdbEasy.DTO.Reviews;
using TmdbEasy.Integration.Tests.TestFixtures;
using TmdbEasy.Interfaces;

namespace TMdbEasy.Integration.Tests
{
    [TestFixture]
    [Category("TmdbEasyClient")]
    public class TmdbEasyClientTest : TestBaseForV3
    {
        [TestCase("5488c29bc3a3686f4a00004a")]
        public async Task GetResponseAsync_WithApiKey_ReturnsResult(string reviewId)
        {
            string queryString = $"review/{reviewId}";

            ITmdbEasyClient client = GetTestV3Client(GetApiKey());

            var result = await client.GetResponseAsync<Review>(queryString).ConfigureAwait(false);

            Assert.IsNotNull(result);
            Assert.AreEqual(reviewId, result.Id);
        }
    }
}
