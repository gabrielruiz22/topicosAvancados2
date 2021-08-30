using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAula230821.Models;

namespace ProjAula230821.Models
{
    public class ProjAula230821Context : DbContext
    {
        public ProjAula230821Context (DbContextOptions<ProjAula230821Context> options)
            : base(options)
        {
        }

        public DbSet<ProjAula230821.Models.Produto> Produto { get; set; }

        public DbSet<ProjAula230821.Models.Funcionario> Funcionario { get; set; }

        public DbSet<ProjAula230821.Models.Fornecedor> Fornecedor { get; set; }
    }
}
