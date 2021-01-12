using System;
using System.Collections.Generic;

namespace IMDB_API.Models
{
    public partial class Genero
    {
        public Genero()
        {
            FilmeGenero = new HashSet<FilmeGenero>();
        }

        public int IdGenero { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<FilmeGenero> FilmeGenero { get; set; }
    }
}
