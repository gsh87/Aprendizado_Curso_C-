using System;
using Exercicio.Entities;
using Exercicio.Entities.Enuns;
using System.Globalization;
namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Cliente Data: ");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth date DD/MM/YYYY");
            DateTime DataNasc = DateTime.Parse(Console.ReadLine());

            Client Cliente = new Client(name,email,DataNasc);
            DateTime DataOrdem = DateTime.Now;

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order Ordem = new Order(DataOrdem, status, Cliente);

            Console.WriteLine("How many items to this order? ");
            int N = int.Parse(Console.ReadLine());
            for(int k = 1;k<=N;k++)
            {
                Console.WriteLine($"Enter #{k} item data:");
                Console.Write("Product name: ");
                string item = Console.ReadLine();
                Console.Write("Product Price: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");

                int quantidade = int.Parse(Console.ReadLine());
                Product produto = new Product(item, preco);
                OrderItem NovoItem = new OrderItem(produto, preco, quantidade);
                Ordem.AddOrder(NovoItem);

            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(Ordem);

        }
    }
}
