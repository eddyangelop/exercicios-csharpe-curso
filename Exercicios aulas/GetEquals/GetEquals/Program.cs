using System;

namespace Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Maria";
            string c = "João";

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(b.Equals(c));
        }
    }
}