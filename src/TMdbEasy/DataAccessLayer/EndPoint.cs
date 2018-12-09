using System;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Web;

namespace TMdbEasy.DataAccessLayer
{
    public abstract class EndPoint
    {
        private static IWebClient _webClient;
        private readonly UriBuilder _baseAddress;

        public NameValueCollection Query { get; set; }



        public EndPoint(string path)
            : this(path, new Client()) { }

        public EndPoint(string path, IWebClient webClient)
        {
            _baseAddress = new UriBuilder("http://api.themoviedb.org/3/")
            {
                Path = path
            };

            _webClient = webClient;

            Query = HttpUtility.ParseQueryString(_baseAddress.Query);
        }



        protected async Task<string> CallApi()
        {
            return await _webClient.GetStringAsync(_baseAddress.Uri);
        }
    }
}
