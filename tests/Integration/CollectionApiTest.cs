using NUnit.Framework;
using System.Threading.Tasks;
using TmdbEasy.DTO.Images;
using TmdbEasy.DTO.Other;
using TmdbEasy.Tests.Integration.TestFixtures;
using TmdbEasy.Interfaces;

namespace TmdbEasy.Tests.Integration
{
    [TestFixture]
    [Category("CollectionApi")]
    public class CollectionApiTest : TestBaseForV3
    {
        [TestCase(10)]
        public async Task GetDetailsAsync_ValidId_ReturnsValidResult(int id)
        {
            ICollectionApi apiUnderTest = _clientWithNoApiKey.Collection;

            Collections collections = await apiUnderTest.GetDetailsAsync(id, _userApiKey);

            Assert.IsNotNull(collections);
            Assert.AreEqual(id, collections.Id);
            Assert.IsNotEmpty(collections.Parts);
        }

        [TestCase(10)]
        public async Task GetImagesAsync_ValidId_ReturnsValidResult(int id)
        {
            ICollectionApi apiUnderTest = _clientWithNoApiKey.Collection;

            Images images= await apiUnderTest.GetImagesAsync(id, _userApiKey);

            Assert.IsNotNull(images);
            Assert.AreEqual(id, images.Id);
            Assert.IsNotEmpty(images.Posters);
            Assert.IsNull(images.Stills);
            Assert.IsNotEmpty(images.Backdrops);
        }
    }
}
