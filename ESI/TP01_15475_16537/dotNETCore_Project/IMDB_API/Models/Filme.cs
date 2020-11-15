using System;
using System.Collections.Generic;

namespace IMDB_API.Models
{
    public partial class Filme
    {
        public Filme()
        {
            FilmeGenero = new HashSet<FilmeGenero>();
        }

        public int Tconst { get; set; }
        public string TitleType { get; set; }
        public string PrimaryTitle { get; set; }
        public string OriginalTitle { get; set; }
        public bool IsAdult { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public int? RuntimeMinutes { get; set; }

        public virtual ICollection<FilmeGenero> FilmeGenero { get; set; }
    }
}
