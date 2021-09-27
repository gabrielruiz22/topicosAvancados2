using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjBibliotecaP1.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string NomeDoLivro { get; set; }
        public Autor autor { get; set; }
        public Boolean Disponivel { get; set; }
    }
}
