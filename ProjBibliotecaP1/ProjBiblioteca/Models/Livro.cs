using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjBibliotecaP1.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string NomeDoLivro { get; set; }
        public virtual Autor autor { get; set; }
        public Boolean Disponivel { get; set; }

        [NotMapped]
        public virtual List<SelectListItem> Autores { get; set; }
    }
}
