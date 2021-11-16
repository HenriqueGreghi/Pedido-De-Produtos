using System;
using PedidoProdutos.Entidades.Enums;
using PedidoProdutos.Entidades;
using System.Globalization;


namespace PedidoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string Nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime Moment = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            PedidoStatus status = Enum.Parse<PedidoStatus>(Console.ReadLine());

            Cliente cliente = new Cliente (Nome, email, Moment);
            Pedido pedido = new Pedido(Moment, status, cliente);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string ProdutoNome = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(Nome, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Item orderItem = new Item(quantity, price, produto);

                Item.AddItem(produto);
               
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(pedido);
        }
    }
}
