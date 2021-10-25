using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4patas.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public Animal Animal { get; set; }
    }
}
