﻿using System.Collections.Generic;

namespace TMdbEasy.TmdbObjects.Movies
{
    public class Videos
    {
        public string Id { get; set; }
        public string Iso_639_1 { get; set; }
        public string Iso_3166_1 { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public string Site { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
    }

    public class VideoList
    {
        public int Id { get; set; }
        public List<Result> Results { get; set; }
    }
}
