using System;
using System.Globalization;
using OrderClient.Entities;
using OrderClient.Entities.Enums;

namespace OrderClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            // Entrar com o nome do cliente
            Console.Write("Name: ");
            string clientName = Console.ReadLine();

            // Entrar com o e-mail
            Console.Write("Email: ");
            string email = Console.ReadLine();

            // Entrar com a data de aniversario
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            // Entrar com status do pedido
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            // Declaração de entidade Class client  e Class order de pedido
            Client client = new Client(clientName, email, birthDate);
            Order order = new Order(DateTime.Now, status, client);

            // entrar com a quantidade de itens no pedido
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());


            // Escopo de incerssão de itens no pedido
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, price, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
