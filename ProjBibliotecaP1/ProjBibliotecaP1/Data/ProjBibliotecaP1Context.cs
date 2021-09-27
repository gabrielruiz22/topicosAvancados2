using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjBibliotecaP1.Models;

namespace ProjBibliotecaP1.Data
{
    public class ProjBibliotecaP1Context : DbContext
    {
        public ProjBibliotecaP1Context (DbContextOptions<ProjBibliotecaP1Context> options)
            : base(options)
        {
        }

        public DbSet<ProjBibliotecaP1.Models.Cidade> Cidade { get; set; }

        public DbSet<ProjBibliotecaP1.Models.Livro> Livro { get; set; }

        public DbSet<ProjBibliotecaP1.Models.Autor> Autor { get; set; }

        public DbSet<ProjBibliotecaP1.Models.Biblioteca> Biblioteca { get; set; }
    }
}
