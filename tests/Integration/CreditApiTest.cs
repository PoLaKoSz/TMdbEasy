﻿using NUnit.Framework;
using System.Threading.Tasks;
using TmdbEasy.DTO.Other;
using TmdbEasy.Interfaces;
using TmdbEasy.Tests.Integration.TestFixtures;

namespace TmdbEasy.Tests.Integration
{
    [Category("CreditApi")]
    internal class CreditApiTest : TestBaseForV3
    {
        [TestCase("52542282760ee313280017f9")]
        public async Task GetDetailsAsync_ValidId_CustomApiKey_ReturnsValidResult(string id)
        {
            ICreditApi apiUnderTest = _clientWithNoApiKey.Credit;

            Credits details = await apiUnderTest.GetDetailsAsync(id, _userApiKey);

            Assert.IsNotNull(details);
            Assert.AreEqual(id, details.Id);
        }

        [TestCase("52542282760ee313280017f9")]
        public async Task GetDetailsAsync_ValidId_DefaultApiKey_ReturnsValidResult(string id)
        {
            ICreditApi apiUnderTest = _clientWithNoApiKey.Credit;

            Credits details = await apiUnderTest.GetDetailsAsync(id, _userApiKey);

            Assert.IsNotNull(details);
            Assert.AreEqual(id, details.Id);
        }
    }
}
