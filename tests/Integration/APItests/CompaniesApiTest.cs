﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMdbEasy.ApiInterfaces;
using SUT = TMdbEasy;

namespace TMdbEasy_Tests.APItests
{
    [Category("CompaniesApi")]
    internal static class CompaniesApiTest
    {
        [TestFixture]
        [Category("CompaniesApi")]
        public class GetDetailsAsync
        {
            [TestCase(296096321)]
            public void IncorrectId_ThrowsException(int id)
            {
                var d = Constants.SecureTestClient.GetApi<ICompaniesApi>().Value;

                Assert.Throws<AggregateException>(() => { SUT.TmdbObjects.Companies.CompanyDetails cd = d.GetDetailsAsync(id).Result; });
            }
        }

        [TestFixture]
        [Category("CompaniesApi")]
        public class GetMoviesAsync
        {
            [TestCase(254665465)]
            public void IncorrectId_ThrowsException(int id, string language = "en")
            {
                var d = Constants.SecureTestClient.GetApi<ICompaniesApi>().Value;

                Assert.Throws<AggregateException>(() => { SUT.TmdbObjects.Companies.MoviesByCompany mbc = d.GetMoviesAsync(id, language).Result; });
            }
        }
    }
}
