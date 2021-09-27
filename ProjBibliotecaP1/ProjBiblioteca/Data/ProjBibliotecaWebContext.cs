using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjBibliotecaP1.Models;

namespace ProjBibliotecaWeb.Data
{
    public class ProjBibliotecaWebContext : DbContext
    {
        public ProjBibliotecaWebContext (DbContextOptions<ProjBibliotecaWebContext> options)
            : base(options)
        {
        }

        public DbSet<ProjBibliotecaP1.Models.Autor> Autor { get; set; }

        public DbSet<ProjBibliotecaP1.Models.Biblioteca> Biblioteca { get; set; }

        public DbSet<ProjBibliotecaP1.Models.Cidade> Cidade { get; set; }

        public DbSet<ProjBibliotecaP1.Models.Livro> Livro { get; set; }
    }
}
