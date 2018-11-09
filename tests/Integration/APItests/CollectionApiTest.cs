using NUnit.Framework;
using System;
using TMdbEasy.ApiInterfaces;
using SUT = TMdbEasy;

namespace TMdbEasy_Tests.APItests
{
    [Category("CollectionApi")]
    internal static class CollectionApiTest
    {
        [TestFixture]
        [Category("CollectionApi")]
        public class GetDetailsAsync
        {
            [TestCase(296096321)]
            public void IncorrectId_ThrowsException(int id, string language = "en")
            {
                var d = Constants.SecureTestClient.GetApi<ICollectionApi>().Value;

                Assert.Throws<AggregateException>(() => { SUT.TmdbObjects.Collection.Collections col = d.GetDetailsAsync(id, language).Result; });
            }
        }

        [TestFixture]
        [Category("CollectionApi")]
        public class GetImagesAsync
        {
            [TestCase(296096321)]
            public void IncorrectId_ThrowsException(int id, string language = "en")
            {
                var d = Constants.SecureTestClient.GetApi<ICollectionApi>().Value;

                Assert.Throws<AggregateException>(() => { SUT.TmdbObjects.Images.Images ima = d.GetImagesAsync(id, language).Result; });
            }
        }
    }
}
