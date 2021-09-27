using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjBibliotecaP1.Models
{
    public class Biblioteca
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public virtual Livro Livro { get; set; }

        [NotMapped]
        public virtual List<SelectListItem> Livros { get; set; }
    }
}
