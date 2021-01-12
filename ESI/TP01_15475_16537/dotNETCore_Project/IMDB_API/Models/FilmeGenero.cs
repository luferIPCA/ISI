using System;
using System.Collections.Generic;

namespace IMDB_API.Models
{
    public partial class FilmeGenero
    {
        public int Tconst { get; set; }
        public int IdGenero { get; set; }

        public virtual Genero IdGeneroNavigation { get; set; }
        public virtual Filme TconstNavigation { get; set; }
    }
}
