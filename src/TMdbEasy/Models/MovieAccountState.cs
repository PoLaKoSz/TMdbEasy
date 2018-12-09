using Newtonsoft.Json;

namespace TMdbEasy.Models
{
    public class MovieAccountState
    {
        public int ID { get; }
        public bool IsFavourite { get; }
        public object Rated { get; set; }
        public bool IsWatchListed { get; }



        public MovieAccountState(
            [JsonProperty("id")] int id,
            [JsonProperty("favorite")] bool isFavourite,
            [JsonProperty("rated")] object rated,
            [JsonProperty("watchlist")] bool isWatchListed)
        {
            ID = id;
            IsFavourite = isFavourite;
            Rated = rated;
            IsWatchListed = isWatchListed;
        }
    }
}
