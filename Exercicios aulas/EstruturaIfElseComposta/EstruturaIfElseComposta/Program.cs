using System;

namespace estrutura_if_else_composto
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com um nímero inteiro:");
            int x = int.Parse(Console.ReadLine());



            if (x % 2 == 0)

            {

                Console.WriteLine("Par!");

            }
            else

                Console.WriteLine("Impar!");




        }
    }
}
