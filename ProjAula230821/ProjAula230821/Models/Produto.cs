using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjAula230821.Models
{
    public class Produto {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Valor { get; set; }
        public DateTime DtCadastro { get; set; }
    }

}
