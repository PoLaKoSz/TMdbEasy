using System.Collections.Generic;

namespace TMdbEasy.TmdbObjects.Certifications
{
    public class TvContentRating
    {
        public string Iso_3166_1 { get; set; }
        public string Rating { get; set; }
    }

    public class TvRatingList
    {
        public List<TvContentRating> Results { get; set; }
    }
}
