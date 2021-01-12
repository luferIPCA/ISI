using System.Collections.Generic;

namespace IMDB_API.Models
{
    public class FilmeGet
    {
        public int Tconst { get; set; }
        public string TitleType { get; set; }
        public string PrimaryTitle { get; set; }
        public string OriginalTitle { get; set; }
        public bool IsAdult { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public int? RuntimeMinutes { get; set; }

        public List<string> FilmeGenero { get; set; }
    }
}