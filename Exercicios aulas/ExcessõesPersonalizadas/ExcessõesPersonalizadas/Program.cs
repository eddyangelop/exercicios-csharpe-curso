using System;
using System.Net.WebSockets;
using ExcessoesPersonalizadas.Entities;

namespace excessoes_personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBS:
            // Essa é uma forma (muito ruim) de validação de lógica do reservation Program principal
            // Lógica de validação não delega a reserva.
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());


            if (checkOut <= checkIn)
            {
                Console.WriteLine("Error in reservaton! check-out date must be after check-in date.");
            }
            else
            {
                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Enter data to update the reservation:");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                // DateTime.Now Testa se o dia atual esta sendo respeitado.
                DateTime now = DateTime.Now;
                if (checkIn < now || checkOut < now)
                {
                    Console.WriteLine("Error in reservation: Reservation dates for update must be future dates.");
                }
                else if (checkOut <= checkIn)
                {
                    Console.WriteLine("Error in reservaton! check-out date must be after check-in date.");
                }
                else
                {
                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);

                }

            }


        }
    }
}
