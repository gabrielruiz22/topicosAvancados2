using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjBibliotecaP1.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public String NomeAutor { get; set; }
        public int quantidadeLivrosPublicados { get; set; }
        public virtual Cidade cidade { get; set; }

        [NotMapped]
        public virtual List<SelectListItem> Cidade { get; set; }
    }
}
