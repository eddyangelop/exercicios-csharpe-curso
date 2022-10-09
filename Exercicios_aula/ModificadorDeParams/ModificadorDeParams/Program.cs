using System;

namespace ModificadorDeParams
{
    class Program
    {
        static void Main(string[]args)
        {

            /* FORMA RUIM
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);
            Console.WriteLine(s1);
            */

            /* FORMA BOA
            int s1 = Calculator.Sum(new int[] { 2, 3 });
            int s2 = Calculator.Sum(new int[] { 2, 4, 3});

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            */

            // COM PARAMS
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(21, 44, 13);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}