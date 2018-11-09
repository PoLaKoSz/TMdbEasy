using System.Collections.Generic;

namespace TMdbEasy.TmdbObjects.Language
{
    public class Translation
    {
        public string Iso_639_1 { get; set; }
        public string Iso_3166_1 { get; set; }
        public string Name { get; set; }
        public string English_name { get; set; }
    }

    public class TranslationsList
    {
        public int Id { get; set; }
        public List<Translation> Translations { get; set; }
    }
}
