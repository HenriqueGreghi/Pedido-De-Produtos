using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using PedidoProdutos.Entidades.Enums;

namespace PedidoProdutos.Entidades
{
    public class Pedido
    {
        private DateTime moment;
        private Cliente cliente;

        public Pedido(DateTime moment, PedidoStatus status, Cliente cliente)
        {
            this.moment = moment;
            Status = status;
            this.cliente = cliente;
        }

        public DateTime Momet { get; set; }
        public PedidoStatus Status { get; set; }
        public Cliente Clinte { get; set; }

       
    }
}
