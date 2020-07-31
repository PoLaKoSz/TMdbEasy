using System;
using System.Runtime.InteropServices;
using TmdbEasy.Configurations;
using TmdbEasy.Interfaces;

namespace TmdbEasy.Tests.Integration.TestFixtures
{
    public abstract class TestBaseForV3
    {
        private const string ApiKeyVariableName = "tmdbapikey";
        protected readonly ITmdbEasyClientv3 _clientWithNoApiKey;
        protected readonly ITmdbEasyClientv3 _clientWithApiKey;

        protected TestBaseForV3()
        {
            _clientWithNoApiKey = GetTestV3Client();
            _clientWithApiKey = GetTestV3Client(GetApiKey());
            _userApiKey = GetApiKey();
        }

        public readonly string _userApiKey;

        public ITmdbEasyClientv3 GetTestV3Client(string sharedApiKey = null)
        {
            var jsonSerializer = new NewtonSoftDeserializer();

            return new TmdbEasyClientv3(GetDefaultOptions(sharedApiKey), jsonSerializer);
        }

        public TmdbEasyOptions GetDefaultOptions(string sharedApiKey)
        {
            return new TmdbEasyOptions(sharedApiKey, useSsl: true, defaultLanguage: "en");
        }

        public string GetApiKey()
        {
            EnvironmentVariableTarget environmentVariableTarget = EnvironmentVariableTarget.User;

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                environmentVariableTarget = EnvironmentVariableTarget.Process;
            }

            return Environment.GetEnvironmentVariable(ApiKeyVariableName, environmentVariableTarget);
        }
    }
}
