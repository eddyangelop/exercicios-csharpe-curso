﻿
using System;

namespace Course {
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa name, age;

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Age = int.Parse(Console.ReadLine());


            if (p1.Age > p2.Age)
            {
                Console.WriteLine("Pessoa Mais velha: " + p1.Name);
            } else
            {
                Console.WriteLine("Pessoa Mais velha: " + p2.Name);
            }



            Console.ReadLine();

        }
    }
}