using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using PedidoProdutos.Entidades.Enums;


namespace PedidoProdutos.Entidades
{
    public class Item
    {
        public int Quantidade { get; set; }
        public double Preço { get; set; }
        public Produto Produto { get; set; }

        public Item(int quantidade, double preço, Produto produto)
        {
            Quantidade = quantidade;
            Preço = preço;
            Produto = produto;
        }
        public double ValorTotal()
        {
            return Quantidade * Preço;
        }
        public override string ToString()
        {
            return Produto.Nome
                + ", $"
                + Preço.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantidade
                + ", Subtotal: $"
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}

