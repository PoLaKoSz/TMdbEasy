using System.Net.Http;
using TmdbEasy.Configurations;

namespace TmdbEasy.Interfaces
{
    internal interface ITmdbEasyClient
    {
        TmdbEasyOptions Options { get; }
        HttpClient HttpClient { get; }
        IJsonDeserializer JsonDeserializer { get; }
    }
}
