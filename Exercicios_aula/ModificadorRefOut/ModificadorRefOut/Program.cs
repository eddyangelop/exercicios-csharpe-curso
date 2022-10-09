using System;

namespace ModificadorRefOut
{
    class Program
    {
        static void Main(string[]args)
        {
            // code smells (design ruins)
            // REF
            int a1 = 10;
            Calculator.Triple(ref a1);
            Console.WriteLine(a1);

            // OUT
            int a2 = 10;
            int triple;
            Calculator.Triple(a2, out triple);
            Console.WriteLine(triple);

        }
    }
}