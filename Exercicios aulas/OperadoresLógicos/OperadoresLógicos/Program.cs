using System;

namespace operadores_logicos
{
    class Program
    {
        static void Main(string[] args)
        {

            //expressão E
            bool c1 = 4 != 5;
            bool c2 = 2 > 3 && 4 != 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);

            Console.WriteLine("--------------------");

            //expressão OU
            bool c3 = 2 > 3 || 4 != 5;

            Console.WriteLine(c3);

            Console.WriteLine("--------------------");

            //expressão NÃO
            bool c4 = !(2 > 3) && 4 != 5;

            Console.WriteLine(c4);

            Console.WriteLine("--------------------");

            bool c5 = 10 < 5;
            Console.WriteLine(c5);

            //expressão de precedência

            bool c6 = c1 || c2 && c3;

            Console.WriteLine(c6);




            Console.ReadLine();
        }
    }
}
