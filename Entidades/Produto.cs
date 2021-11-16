using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PedidoProdutos.Entidades.Enums;

namespace PedidoProdutos.Entidades
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preço { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preço)
        {
            Nome = nome;
            Preço = preço;
        }
    }
}
