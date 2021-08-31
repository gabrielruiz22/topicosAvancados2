using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAPIDotNETCore3008.Model;

namespace ProjAPIDotNETCore3008.Data
{
    public class ProjAPIDotNETCore3008Context : DbContext
    {
        public ProjAPIDotNETCore3008Context (DbContextOptions<ProjAPIDotNETCore3008Context> options)
            : base(options)
        {
        }

        public DbSet<ProjAPIDotNETCore3008.Model.Person> Person { get; set; }
    }
}
