using System.Text;
using System.Threading.Tasks;
using TmdbEasy.DTO.Changes;
using TmdbEasy.DTO;
using TmdbEasy.Extensions;
using TmdbEasy.Interfaces;

namespace TmdbEasy.Apis
{
    public class ChangesApi : IChangesApi
    {
        private readonly ITmdbEasyClient _client;

        public ChangesApi(ITmdbEasyClient client)
        {
            this._client = client;
        }

        public async Task<ChangeList> GetChangeListAsync(ChangeListRequest changeListRequest)
        {
            string queryString = new StringBuilder()
            .Append(changeListRequest.Type.ToString().ToLower())
            .Append("/changes?")
            .AppendEndDate(changeListRequest.End_date)
            .AppendStartDate(changeListRequest.Start_date)
            .Append($"&page={changeListRequest.Page}")
            .ToString();

            return await _client.GetResponseAsync<ChangeList>(queryString).ConfigureAwait(false);
        }       
    }
}
