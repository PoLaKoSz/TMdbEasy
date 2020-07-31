using System.Net.Http;
using TmdbEasy.Configurations;
using TmdbEasy.Interfaces;

namespace TmdbEasy.Interfaces
{
    internal interface ITmdbEasyClient
    {
        TmdbEasyOptions Options { get; }
        HttpClient HttpClient { get; }
        IJsonDeserializer JsonDeserializer { get; }
    }
}
