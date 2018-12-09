using System.Threading.Tasks;

namespace TMdbEasy.DataAccessLayer
{
    public class SecureEndPoint : EndPoint
    {
        public string ApiKey { private get; set; }



        public SecureEndPoint(string path)
            : base(path)
        {
            ApiKey = "";
        }



        public bool TestApiKey(string apiKey)
        {
            return false;
        }



        protected async Task<string> CallApi(string query)
        {
            Query["api_key"] = ApiKey;

            return await base.CallApi();
        }
    }
}
