﻿using System;
using System.Net.WebSockets;
using ExcessoesPersonalizadas2.Entities;

namespace excessoes_personalizadas2
{
    class Program
    {
        static void Main(string[] args)
        {
            //OBS:
            // Essa é uma forma (ruim) de validação de lógica do reservation retornando string isso poderá ocorrer conflitos
            // por problemas de delegação e a semantica da operação fica prejudicada.

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

                string error = reservation.UpdateDates(checkIn, checkOut);
                if (error != null)
                {
                    Console.WriteLine("Error in reservation: " + error);
                }
                
                else
                {
                    Console.WriteLine("Reservation: " + reservation);

                }

            }


        }
    }
}
