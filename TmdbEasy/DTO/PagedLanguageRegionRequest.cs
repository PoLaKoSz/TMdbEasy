namespace TmdbEasy.DTO
{
    public class PagedLanguageRegionRequest
    {
        public string Region { get; set; } = "US";
        public string Language { get; set; } = "en";
        public int Page { get; set; } = 1;
    }
}
