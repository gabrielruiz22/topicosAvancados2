using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjBibliotecaP1.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public String NomeAutor { get; set; }
        public int quantidadeLivrosPublicados { get; set; }
        public Cidade cidade { get; set; }
    }
}
