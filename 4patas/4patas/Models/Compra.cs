using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4patas.Models
{
    public class Compra
    {
        public int Id { get; set; }
        public Produto NomeProduto { get; set; }
        public Usuario NomeUsuario { get; set; }
        public Funcionario NomeFuncionario { get; set; }
    }
}
