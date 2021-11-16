using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PedidoProdutos.Entidades
{
    public class Cliente
    {
        public string nome { get; set; }
        public string email { get; set; }
        public DateTime Data { get; set; }
    
    public Cliente()
        {

        }

        public Cliente(string nome, string email, DateTime moment)
        {
            this.nome = nome;
            this.email = email;
        }
    }

}
