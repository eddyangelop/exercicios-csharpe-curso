using EnumBasico.Entities;
using EnumBasico.Entities.Enums;
using System;

namespace enum_basico
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            Console.WriteLine();

            Console.WriteLine("Imprimir status em formato string");
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            Console.WriteLine("Converter strings em formato enums");
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);


            Console.ReadLine();
        }
    }
}